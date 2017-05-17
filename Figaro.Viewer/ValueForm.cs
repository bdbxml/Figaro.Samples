using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Figaro.Viewer
{
    public partial class ValueForm : Form
    {
        public ValueForm(string valueTypes)
        {
            InitializeComponent();
            switch(valueTypes)
            {
                case "ns":
                    Text = "Add Namespace";
                    break;
                case "var":
                    Text = "Add Variable";
                    break;
                default:
                    Text = "Add";
                    break;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            CancelClicked = true;
        }

        public bool CancelClicked { get; set; }

        private void ValueForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)ConsoleKey.Escape)
                Hide();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void ValueForm_Activated(object sender, EventArgs e)
        {
            txtValue.Focus();
            txtValue.SelectAll();
        }
    }
}
