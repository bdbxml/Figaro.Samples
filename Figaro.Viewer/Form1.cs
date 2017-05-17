using System.IO;
using System;
using System.Text;
using System.Xml;
using System.Diagnostics;
using System.Windows.Forms;

namespace Figaro.Viewer
{
    public partial class FrmMain : Form
    {
        private string _containerFileName;
        private string _queryFileName;
        private readonly XmlManager _mgr;
        private XmlResults _results;
        private Container _container;
        private readonly Stopwatch _watch = new Stopwatch();
        private QueryContext _qc;
        private XQueryExpression _qx;
        
        public FrmMain()
        {
            InitializeComponent();
            _mgr = new XmlManager(ManagerInitOptions.AllowAutoOpen | ManagerInitOptions.AllowExternalAccess);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var doc = _container.GetDocument(lbNames.SelectedItem as string);
                dg.Rows.Clear();
                using (var iter = doc.GetMetadataIterator())
                {
                    while (iter.Next())
                    {
                        dg.Rows.Add(iter.Uri, iter.Name, iter.Value.AsString);
                    }
                }
                
                wbFile.Navigate("about:blank");
                if (wbFile.Document != null) wbFile.Document.OpenNew(true);
                wbFile.DocumentText = GetPrettyXmlOutput(doc.ToString());
            }
            catch (Exception ex)
            {
                HandleException(ex, "SelectDocument");
            }
        }

        private void RefreshQueryTab()
        {
            if (_qc != null)
                pg.SelectedObject = _qc;
            if (_qx == null) return;
            _qx.Dispose();
            _qx = null;
        }

        private void OpenContainer(string containerName)
        {
            try
            {
                if (!_mgr.ExistsContainer(containerName))
                {
                    var msg = $"Specified container does not exist: {containerName}";
                    ContainerStatus(msg);
                    MessageBox.Show(msg);
                    return;
                }
                _container?.Dispose();
                Cursor = Cursors.WaitCursor;
                _container = _mgr.OpenContainer(containerName);
                _container.AddAlias(Path.GetFileNameWithoutExtension(containerName));
                ContainerStatus("Container: {0} (alias: '{1}')", Path.GetFileName(containerName),
                                Path.GetFileNameWithoutExtension(containerName));                
            }
            catch (Exception ex)
            {
                var x = HandleException(ex, "OpenContainer");
                if (null != x) throw x;
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private static Exception HandleException(Exception ex, string message)
        {
            MessageBox.Show(ex.Message, message);
            return null;
        }

        ~FrmMain()
        {
            _mgr.Dispose();
        }

        private void openContainerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenContainer(GetNewContainerFileName());
            RefreshContainerView();
        }

        private void frmMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void tcMain_Selected(object sender, TabControlEventArgs e)
        {
            if (null == _qc) _qc = _mgr.CreateQueryContext(EvaluationType.Eager);
            RefreshQueryTab();
        }

        private void tpFile_Click(object sender, EventArgs e)
        {

        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshContainerView();
        }

        private void openQueryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenQuery();
        }

        private bool _dirtyQuery;
        private bool _prepared;

        private void txtQuery_TextChanged(object sender, EventArgs e)
        {
            _dirtyQuery = true;
            _prepared = false;
        }

        private void executeQueryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveQueryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_queryFileName))
            {
                _queryFileName = GetNewQueryFileName();
            }
        }

        #region UI commands

        private void PrepareQuery()
        {
            try
            {
                StartTimer();
                _qx?.Dispose();
                _qx = _mgr.Prepare(txtQuery.Text, _qc);
                if (wbQuery.Document != null) wbQuery.Document.OpenNew(true);
                wbQuery.DocumentText = GetPrettyXmlOutput(_qx.QueryPlan);
            }
            catch(Exception ex)
            {
                wbQuery.Navigate("about:blank");
                if (wbQuery.Document != null) wbQuery.Document.OpenNew(true);
                wbQuery.DocumentText = GetPrettyTextOutput($"{ex.GetType()}:{ex.Message}");
            }
            finally
            {
                StopTimer("prepared query");
            }
        }

        private void OpenQuery()
        {
            if (_dirtyQuery)
            {
                var result = MessageBox.Show(@"Save your current query?", @"Save Query", MessageBoxButtons.YesNoCancel);
                switch(result)
                {
                    case DialogResult.Yes:
                    {
                        CloseQuery();
                        break;
                    }
                    case DialogResult.Cancel:
                    {
                        return;
                    }
                }
            }
        }

        private static string GetPrettyXmlOutput(string output)
        {
            var ms = new MemoryStream(Encoding.Default.GetBytes(res.xmltrans));
            ms.Seek(0, SeekOrigin.Begin);
            var reader = XmlReader.Create(ms);
            var trans = new System.Xml.Xsl.XslCompiledTransform();
            trans.Load(reader);
            var sb = new StringBuilder();
            var writer = XmlWriter.Create(sb);
            var input = XmlReader.Create(new MemoryStream(Encoding.Default.GetBytes(output)));
            trans.Transform(input, writer);
            return sb.ToString();
        }

        private static string GetPrettyTextOutput(string output)
        {
            var sb = new StringBuilder();
            sb.Append("<html><head/>");
            sb.Append(output);
            sb.Append("</html>");
            return sb.ToString();
        }

        private void RefreshContainerView()
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                LoadList();
                wbFile.Navigate("about:blank");
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private string GetNewQueryFileName()
        {
            sfdFile.DefaultExt = "*.xq";
            sfdFile.Filter = @"XML Query Files (*.xq) | *.xq";
            var result = sfdFile.ShowDialog();
            return result == DialogResult.OK || result == DialogResult.Yes ? sfdFile.FileName : string.Empty;
        }

        private string GetNewContainerFileName()
        {            
            ofdFile.DefaultExt = "*.dbxml";
            ofdFile.Filter = @"XML Database Files (*.dbxml) | *.dbxml";
            var result = ofdFile.ShowDialog();
            if (result != DialogResult.OK) return string.Empty;
            _containerFileName = ofdFile.FileName;            
            return _containerFileName;
        }

        private void LoadList()
        {
            try
            {
                StartTimer();
                var i = 0;
                lbNames.Items.Clear();
                using (var results = _container.GetAllDocuments())
                {
                    while (results.HasNext())
                    {
                        i++;
                        lbNames.Items.Add(results.NextDocument().Name);
                    }
                }
                StopTimer("loaded " + i + " document names");
            }
            catch (Exception ex)
            {
                var x = HandleException(ex, "LoadList");
                if (x != null) throw x;
            }
        }

        private void StartTimer()
        {
            if (!_watch.IsRunning)
                _watch.Start();
        }

        private void StopTimer(string action)
        {
            _watch.Stop();
            PerfStatus("{0} in {1} seconds.", action, _watch.Elapsed.TotalSeconds);
            _watch.Reset();
        }

        private void ExecuteQuery()
        {
            StartTimer();
            try
            {
                wbQuery.Navigate("about:blank");
                wbQuery.Document?.OpenNew(true);

                var sb = new StringBuilder();
                if (null != _qx && _prepared)
                {                    
                    _results = _qx.Execute(_qc);
                }
                else
                {
                    _results = _mgr.Query(txtQuery.Text, _qc, QueryOptions.None);

                    if (_results.GetSize() > 0)
                    {
                        while (_results.HasNext())
                        {
                            sb.Append(_results.NextValue().AsString);
                        }
                    }
                    else
                    {
                        rbHtml.Checked = true;
                        sb.Append("<html><p>Query returned no results.</p></html>");
                    }

                    if (rbXml.Checked)
                        wbQuery.DocumentText = GetPrettyXmlOutput(sb.ToString());
                    if (rbHtml.Checked)
                        wbQuery.DocumentText = _results.ToString();
                    if (rbText.Checked)
                        wbQuery.DocumentText = GetPrettyTextOutput(sb.ToString());
                }
            }
            catch (Exception ex)
            {
                HandleQueryException(ex);
            }
            finally
            {
                StopTimer("executed query");
            }
        }

        private void HandleQueryException(Exception ex)
        {
            wbQuery.Navigate("about:blank");
            wbQuery.Document?.OpenNew(true);
            var sb = new StringBuilder();
            sb.Append("<html><head/>");
            sb.AppendFormat("{0}:{1}", ex.GetType(), ex.Message);
            sb.Append("</html>");
            wbQuery.DocumentText = sb.ToString();
        }

        private void PerfStatus(string message, params object[] args)
        {
            tslPerf.Text = args == null ? message : string.Format(message, args);
        }

        private void ContainerStatus(string message, params object[] args)
        {
            tslContainer.Text = args == null ? message : string.Format(message, args);            
        }

        private void ResetQueryContext()
        {
            dgNamespaces.Rows.Clear();
            dgVariables.Rows.Clear();
            pg.Refresh();
            wbQuery.Navigate("about:blank");
            txtQuery.Text = string.Empty;
        }

        private void SetVariable(string name, string val)
        {
            if (_qc != null)
            {
                _qc.SetVariableValue(name, val);
                dgVariables.Rows.Add(name, val);
            }
        }

        private void SetNamespaces(string name, string val)
        {
            if (_qc != null)
            {
                _qc.SetNamespace(name, val);
                dgNamespaces.Rows.Add(new object[] {name,val});
            }
        }
        private void SaveQuery()
        {
            if (string.IsNullOrEmpty(_queryFileName)) _queryFileName = GetNewQueryFileName();
            File.WriteAllText(_queryFileName, txtQuery.Text);
        }

        private void ResultsToText()
        {
            wbQuery.Navigate("about:blank");
            wbQuery.Document?.OpenNew(false);

            var sb = new StringBuilder();
            if (!_results.IsNull() && _results.GetSize() > 0)
            {
                while (_results.HasNext())
                {
                    sb.Append(_results.NextValue().AsString);
                }
                _results.Reset();
            }
            if (rbText.Checked) wbQuery.DocumentText = GetPrettyTextOutput(sb.ToString());
            if (rbXml.Checked) wbQuery.DocumentText = GetPrettyXmlOutput(sb.ToString());
        }

        private void CloseQuery()
        {
            if (_dirtyQuery)
            {
                var result = MessageBox.Show(@"Save your current query?", @"Save Query", MessageBoxButtons.YesNoCancel);
                switch (result)
                {
                    case DialogResult.Yes:
                        SaveQuery();
                        break;
                    case DialogResult.No:
                        break;
                    case DialogResult.Cancel:
                        return;
                }
                wbQuery.Navigate("about:blank");
                txtQuery.Text = string.Empty;
            }
            _dirtyQuery = false;
            _queryFileName = string.Empty;
        }

        #endregion

        private void closeQueryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void prepareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                PrepareQuery();
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void resetContextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _qc?.Dispose();

            _qc = _mgr.CreateQueryContext(EvaluationType.Eager);
            ResetQueryContext();
            
        }

        private void executeQueryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                ExecuteQuery();
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void rbText_CheckedChanged(object sender, EventArgs e)
        {
            if (null == _results) return;
            Cursor = Cursors.WaitCursor;
            try
            {
            wbQuery.Navigate("about:blank");
            wbQuery.Document?.OpenNew(false);
            var sb = new StringBuilder();
            if (!_results.IsNull() && _results.GetSize() > 0)
            {
                while (_results.HasNext())
                {
                    sb.Append(_results.NextValue().AsString);
                }
                _results.Reset();
            }
            if (rbText.Checked) wbQuery.DocumentText = GetPrettyTextOutput(sb.ToString());
            }
            finally
            {
                Cursor = Cursors.Default;
            }

        }

        private void rbHtml_CheckedChanged(object sender, EventArgs e)
        {
            if (null == _results) return;
            Cursor = Cursors.WaitCursor;
            try
            {
                wbQuery.Navigate("about:blank");
                wbQuery.Document?.OpenNew(false);
                var sb = new StringBuilder();
                if (!_results.IsNull() && _results.GetSize() > 0)
                {
                    while (_results.HasNext())
                    {
                        sb.Append(_results.NextValue().AsString);
                    }
                    _results.Reset();
                    if (rbText.Checked) wbQuery.DocumentText = sb.ToString();
                }
            }
            catch(Exception ex)
            {
                HandleQueryException(ex);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void rbXml_CheckedChanged(object sender, EventArgs e)
        {
            if (null == _results) return;
            Cursor = Cursors.WaitCursor;
            try
            {

            wbQuery.Navigate("about:blank");
            var sb = new StringBuilder();
            if (null != _results && !_results.IsNull() && _results.GetSize() > 0)
            {
                while (_results.HasNext())
                {
                    sb.Append(_results.NextValue().AsString);
                }
                _results.Reset();
                wbQuery.DocumentText = GetPrettyXmlOutput(sb.ToString());
            }
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void txtQuery_TextChanged_1(object sender, EventArgs e)
        {
            _dirtyQuery = true;
        }

        private void addVariableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var vf = new ValueForm("var");
            var dr = vf.ShowDialog();
            if (dr == DialogResult.OK)
            {
                SetVariable(vf.txtVar.Text, vf.txtValue.Text);
            }
            vf.Close();
            vf.Dispose();
        }

        private void addNamespaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var vf = new ValueForm("var");
            var dr = vf.ShowDialog();
            if (dr == DialogResult.OK)
            {
                SetVariable(vf.txtVar.Text, vf.txtValue.Text);
            }
            vf.Close();
            vf.Dispose();
        }
    }
}
