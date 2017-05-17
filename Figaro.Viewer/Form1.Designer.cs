namespace Figaro.Viewer
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ts = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslPerf = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslContainer = new System.Windows.Forms.ToolStripStatusLabel();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpFile = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lbNames = new System.Windows.Forms.ListBox();
            this.dg = new System.Windows.Forms.DataGridView();
            this.NsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wbFile = new System.Windows.Forms.WebBrowser();
            this.tpQuery = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.rbXml = new System.Windows.Forms.RadioButton();
            this.rbHtml = new System.Windows.Forms.RadioButton();
            this.rbText = new System.Windows.Forms.RadioButton();
            this.wbQuery = new System.Windows.Forms.WebBrowser();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgVariables = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgNamespaces = new System.Windows.Forms.DataGridView();
            this.Prefix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Namespace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pg = new System.Windows.Forms.PropertyGrid();
            this.ofdFile = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openContainerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openQueryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveQueryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeQueryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryContextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prepareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.executeQueryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.resetContextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addVariableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNamespaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sfdFile = new System.Windows.Forms.SaveFileDialog();
            this.statusStrip1.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tpFile.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.tpQuery.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.gbOptions.SuspendLayout();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVariables)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgNamespaces)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts,
            this.tslPerf,
            this.tslContainer});
            this.statusStrip1.Location = new System.Drawing.Point(0, 635);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(904, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ts
            // 
            this.ts.Name = "ts";
            this.ts.Size = new System.Drawing.Size(0, 17);
            // 
            // tslPerf
            // 
            this.tslPerf.AutoSize = false;
            this.tslPerf.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tslPerf.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.tslPerf.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tslPerf.Margin = new System.Windows.Forms.Padding(0, 3, 10, 2);
            this.tslPerf.Name = "tslPerf";
            this.tslPerf.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.tslPerf.Size = new System.Drawing.Size(300, 17);
            this.tslPerf.Text = "Ready";
            this.tslPerf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tslContainer
            // 
            this.tslContainer.AutoSize = false;
            this.tslContainer.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tslContainer.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.tslContainer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tslContainer.Name = "tslContainer";
            this.tslContainer.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.tslContainer.Size = new System.Drawing.Size(300, 17);
            this.tslContainer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tcMain
            // 
            this.tcMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tcMain.Controls.Add(this.tpFile);
            this.tcMain.Controls.Add(this.tpQuery);
            this.tcMain.Location = new System.Drawing.Point(0, 54);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(904, 578);
            this.tcMain.TabIndex = 1;
            this.tcMain.Selected += new System.Windows.Forms.TabControlEventHandler(this.tcMain_Selected);
            // 
            // tpFile
            // 
            this.tpFile.Controls.Add(this.splitContainer1);
            this.tpFile.Location = new System.Drawing.Point(4, 22);
            this.tpFile.Name = "tpFile";
            this.tpFile.Padding = new System.Windows.Forms.Padding(3);
            this.tpFile.Size = new System.Drawing.Size(896, 552);
            this.tpFile.TabIndex = 0;
            this.tpFile.Text = "File View";
            this.tpFile.UseVisualStyleBackColor = true;
            this.tpFile.Click += new System.EventHandler(this.tpFile_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lbNames);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dg);
            this.splitContainer1.Panel2.Controls.Add(this.wbFile);
            this.splitContainer1.Size = new System.Drawing.Size(885, 543);
            this.splitContainer1.SplitterDistance = 137;
            this.splitContainer1.TabIndex = 11;
            // 
            // lbNames
            // 
            this.lbNames.FormattingEnabled = true;
            this.lbNames.Location = new System.Drawing.Point(5, 3);
            this.lbNames.Name = "lbNames";
            this.lbNames.Size = new System.Drawing.Size(128, 537);
            this.lbNames.TabIndex = 4;
            this.lbNames.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // dg
            // 
            this.dg.AllowUserToAddRows = false;
            this.dg.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NsColumn,
            this.NameColumn,
            this.ValueColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg.DefaultCellStyle = dataGridViewCellStyle2;
            this.dg.Location = new System.Drawing.Point(3, 3);
            this.dg.Name = "dg";
            this.dg.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dg.Size = new System.Drawing.Size(755, 127);
            this.dg.TabIndex = 10;
            // 
            // NsColumn
            // 
            this.NsColumn.HeaderText = "Namespace";
            this.NsColumn.Name = "NsColumn";
            this.NsColumn.ReadOnly = true;
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            // 
            // ValueColumn
            // 
            this.ValueColumn.HeaderText = "Value";
            this.ValueColumn.Name = "ValueColumn";
            this.ValueColumn.ReadOnly = true;
            // 
            // wbFile
            // 
            this.wbFile.AllowWebBrowserDrop = false;
            this.wbFile.Location = new System.Drawing.Point(3, 185);
            this.wbFile.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbFile.Name = "wbFile";
            this.wbFile.ScriptErrorsSuppressed = true;
            this.wbFile.Size = new System.Drawing.Size(738, 343);
            this.wbFile.TabIndex = 8;
            this.wbFile.Url = new System.Uri("about:blank", System.UriKind.Absolute);
            // 
            // tpQuery
            // 
            this.tpQuery.Controls.Add(this.splitContainer2);
            this.tpQuery.Controls.Add(this.splitContainer3);
            this.tpQuery.Location = new System.Drawing.Point(4, 22);
            this.tpQuery.Name = "tpQuery";
            this.tpQuery.Padding = new System.Windows.Forms.Padding(3);
            this.tpQuery.Size = new System.Drawing.Size(896, 552);
            this.tpQuery.TabIndex = 1;
            this.tpQuery.Text = "Query View";
            this.tpQuery.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Location = new System.Drawing.Point(254, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.txtQuery);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.gbOptions);
            this.splitContainer2.Panel2.Controls.Add(this.wbQuery);
            this.splitContainer2.Size = new System.Drawing.Size(643, 546);
            this.splitContainer2.SplitterDistance = 213;
            this.splitContainer2.TabIndex = 13;
            // 
            // txtQuery
            // 
            this.txtQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuery.Location = new System.Drawing.Point(3, 3);
            this.txtQuery.Multiline = true;
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtQuery.Size = new System.Drawing.Size(637, 207);
            this.txtQuery.TabIndex = 4;
            this.txtQuery.TextChanged += new System.EventHandler(this.txtQuery_TextChanged_1);
            // 
            // gbOptions
            // 
            this.gbOptions.Controls.Add(this.rbXml);
            this.gbOptions.Controls.Add(this.rbHtml);
            this.gbOptions.Controls.Add(this.rbText);
            this.gbOptions.Location = new System.Drawing.Point(3, 3);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Size = new System.Drawing.Size(184, 43);
            this.gbOptions.TabIndex = 13;
            this.gbOptions.TabStop = false;
            this.gbOptions.Text = "Output Options";
            // 
            // rbXml
            // 
            this.rbXml.AutoSize = true;
            this.rbXml.Location = new System.Drawing.Point(122, 20);
            this.rbXml.Name = "rbXml";
            this.rbXml.Size = new System.Drawing.Size(47, 17);
            this.rbXml.TabIndex = 2;
            this.rbXml.TabStop = true;
            this.rbXml.Text = "XML";
            this.rbXml.UseVisualStyleBackColor = true;
            this.rbXml.CheckedChanged += new System.EventHandler(this.rbXml_CheckedChanged);
            // 
            // rbHtml
            // 
            this.rbHtml.AutoSize = true;
            this.rbHtml.Location = new System.Drawing.Point(61, 19);
            this.rbHtml.Name = "rbHtml";
            this.rbHtml.Size = new System.Drawing.Size(55, 17);
            this.rbHtml.TabIndex = 1;
            this.rbHtml.TabStop = true;
            this.rbHtml.Text = "HTML";
            this.rbHtml.UseVisualStyleBackColor = true;
            this.rbHtml.CheckedChanged += new System.EventHandler(this.rbHtml_CheckedChanged);
            // 
            // rbText
            // 
            this.rbText.AutoSize = true;
            this.rbText.Checked = true;
            this.rbText.Location = new System.Drawing.Point(7, 20);
            this.rbText.Name = "rbText";
            this.rbText.Size = new System.Drawing.Size(46, 17);
            this.rbText.TabIndex = 0;
            this.rbText.TabStop = true;
            this.rbText.Text = "Text";
            this.rbText.UseVisualStyleBackColor = true;
            this.rbText.CheckedChanged += new System.EventHandler(this.rbText_CheckedChanged);
            // 
            // wbQuery
            // 
            this.wbQuery.AllowWebBrowserDrop = false;
            this.wbQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.wbQuery.Location = new System.Drawing.Point(3, 48);
            this.wbQuery.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbQuery.Name = "wbQuery";
            this.wbQuery.Size = new System.Drawing.Size(637, 275);
            this.wbQuery.TabIndex = 3;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer3.Location = new System.Drawing.Point(2, 5);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer3.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer3.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer3.Size = new System.Drawing.Size(891, 551);
            this.splitContainer3.SplitterDistance = 246;
            this.splitContainer3.TabIndex = 14;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dgVariables);
            this.groupBox3.Location = new System.Drawing.Point(8, 148);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(229, 139);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Variables";
            // 
            // dgVariables
            // 
            this.dgVariables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVariables.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgVariables.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgVariables.Location = new System.Drawing.Point(3, 22);
            this.dgVariables.MultiSelect = false;
            this.dgVariables.Name = "dgVariables";
            this.dgVariables.ReadOnly = true;
            this.dgVariables.Size = new System.Drawing.Size(223, 114);
            this.dgVariables.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 60;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.HeaderText = "Value";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 59;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgNamespaces);
            this.groupBox2.Location = new System.Drawing.Point(8, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(229, 139);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Namespaces";
            // 
            // dgNamespaces
            // 
            this.dgNamespaces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgNamespaces.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Prefix,
            this.Namespace});
            this.dgNamespaces.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgNamespaces.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgNamespaces.Location = new System.Drawing.Point(3, 22);
            this.dgNamespaces.MultiSelect = false;
            this.dgNamespaces.Name = "dgNamespaces";
            this.dgNamespaces.ReadOnly = true;
            this.dgNamespaces.Size = new System.Drawing.Size(223, 114);
            this.dgNamespaces.TabIndex = 4;
            // 
            // Prefix
            // 
            this.Prefix.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Prefix.HeaderText = "Prefix";
            this.Prefix.Name = "Prefix";
            this.Prefix.ReadOnly = true;
            this.Prefix.Width = 58;
            // 
            // Namespace
            // 
            this.Namespace.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Namespace.HeaderText = "Namespace";
            this.Namespace.Name = "Namespace";
            this.Namespace.ReadOnly = true;
            this.Namespace.Width = 89;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.pg);
            this.groupBox1.Location = new System.Drawing.Point(6, 317);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 221);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Query Context Properties";
            // 
            // pg
            // 
            this.pg.Location = new System.Drawing.Point(6, 19);
            this.pg.Name = "pg";
            this.pg.Size = new System.Drawing.Size(218, 190);
            this.pg.TabIndex = 0;
            // 
            // ofdFile
            // 
            this.ofdFile.DefaultExt = "*.dbxml";
            this.ofdFile.Filter = "XML Database Files (*.dbxml) | *.dbxml";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.queryToolStripMenuItem,
            this.queryContextToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(904, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openContainerToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(66, 20);
            this.toolStripMenuItem1.Text = "Container";
            // 
            // openContainerToolStripMenuItem
            // 
            this.openContainerToolStripMenuItem.Name = "openContainerToolStripMenuItem";
            this.openContainerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openContainerToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.openContainerToolStripMenuItem.Text = "Open Container...";
            this.openContainerToolStripMenuItem.Click += new System.EventHandler(this.openContainerToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // queryToolStripMenuItem
            // 
            this.queryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openQueryToolStripMenuItem,
            this.saveQueryToolStripMenuItem,
            this.closeQueryToolStripMenuItem});
            this.queryToolStripMenuItem.Name = "queryToolStripMenuItem";
            this.queryToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.O)));
            this.queryToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.queryToolStripMenuItem.Text = "Query";
            // 
            // openQueryToolStripMenuItem
            // 
            this.openQueryToolStripMenuItem.Name = "openQueryToolStripMenuItem";
            this.openQueryToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.openQueryToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.openQueryToolStripMenuItem.Text = "Open...";
            this.openQueryToolStripMenuItem.Click += new System.EventHandler(this.openQueryToolStripMenuItem_Click);
            // 
            // saveQueryToolStripMenuItem
            // 
            this.saveQueryToolStripMenuItem.Name = "saveQueryToolStripMenuItem";
            this.saveQueryToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveQueryToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.saveQueryToolStripMenuItem.Text = "Save";
            this.saveQueryToolStripMenuItem.Click += new System.EventHandler(this.saveQueryToolStripMenuItem_Click);
            // 
            // closeQueryToolStripMenuItem
            // 
            this.closeQueryToolStripMenuItem.Name = "closeQueryToolStripMenuItem";
            this.closeQueryToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt)
                        | System.Windows.Forms.Keys.C)));
            this.closeQueryToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.closeQueryToolStripMenuItem.Text = "Close";
            this.closeQueryToolStripMenuItem.Click += new System.EventHandler(this.closeQueryToolStripMenuItem_Click);
            // 
            // queryContextToolStripMenuItem
            // 
            this.queryContextToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prepareToolStripMenuItem,
            this.executeQueryToolStripMenuItem1,
            this.resetContextToolStripMenuItem,
            this.addVariableToolStripMenuItem,
            this.addNamespaceToolStripMenuItem});
            this.queryContextToolStripMenuItem.Name = "queryContextToolStripMenuItem";
            this.queryContextToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.queryContextToolStripMenuItem.Text = "Query Context";
            // 
            // prepareToolStripMenuItem
            // 
            this.prepareToolStripMenuItem.Name = "prepareToolStripMenuItem";
            this.prepareToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this.prepareToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.prepareToolStripMenuItem.Text = "Prepare";
            this.prepareToolStripMenuItem.Click += new System.EventHandler(this.prepareToolStripMenuItem_Click);
            // 
            // executeQueryToolStripMenuItem1
            // 
            this.executeQueryToolStripMenuItem1.Name = "executeQueryToolStripMenuItem1";
            this.executeQueryToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.executeQueryToolStripMenuItem1.Size = new System.Drawing.Size(171, 22);
            this.executeQueryToolStripMenuItem1.Text = "Execute Query";
            this.executeQueryToolStripMenuItem1.Click += new System.EventHandler(this.executeQueryToolStripMenuItem1_Click);
            // 
            // resetContextToolStripMenuItem
            // 
            this.resetContextToolStripMenuItem.Name = "resetContextToolStripMenuItem";
            this.resetContextToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F8;
            this.resetContextToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.resetContextToolStripMenuItem.Text = "Reset Context";
            this.resetContextToolStripMenuItem.Click += new System.EventHandler(this.resetContextToolStripMenuItem_Click);
            // 
            // addVariableToolStripMenuItem
            // 
            this.addVariableToolStripMenuItem.Name = "addVariableToolStripMenuItem";
            this.addVariableToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.addVariableToolStripMenuItem.Text = "Add Variable";
            this.addVariableToolStripMenuItem.Click += new System.EventHandler(this.addVariableToolStripMenuItem_Click);
            // 
            // addNamespaceToolStripMenuItem
            // 
            this.addNamespaceToolStripMenuItem.Name = "addNamespaceToolStripMenuItem";
            this.addNamespaceToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.addNamespaceToolStripMenuItem.Text = "Add Namespace";
            this.addNamespaceToolStripMenuItem.Click += new System.EventHandler(this.addNamespaceToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 657);
            this.Controls.Add(this.tcMain);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "FrmMain";
            this.Text = "Container Explorer";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmMain_KeyPress);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tcMain.ResumeLayout(false);
            this.tpFile.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.tpQuery.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.gbOptions.ResumeLayout(false);
            this.gbOptions.PerformLayout();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgVariables)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgNamespaces)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ts;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpFile;
        private System.Windows.Forms.TabPage tpQuery;
        private System.Windows.Forms.OpenFileDialog ofdFile;
        private System.Windows.Forms.ListBox lbNames;
        private System.Windows.Forms.ToolStripStatusLabel tslPerf;
        private System.Windows.Forms.ToolStripStatusLabel tslContainer;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openContainerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queryContextToolStripMenuItem;
        private System.Windows.Forms.WebBrowser wbFile;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.DataGridViewTextBoxColumn NsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValueColumn;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prepareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem executeQueryToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openQueryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveQueryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeQueryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetContextToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.WebBrowser wbQuery;
        private System.Windows.Forms.GroupBox gbOptions;
        private System.Windows.Forms.RadioButton rbXml;
        private System.Windows.Forms.RadioButton rbHtml;
        private System.Windows.Forms.RadioButton rbText;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PropertyGrid pg;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgNamespaces;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prefix;
        private System.Windows.Forms.DataGridViewTextBoxColumn Namespace;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgVariables;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.ToolStripMenuItem addVariableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNamespaceToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog sfdFile;
    }
}

