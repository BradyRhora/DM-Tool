using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DM_Tool
{
    public partial class KeyEditDialog : Form
    {
        public KeyEditDialog()
        {
            InitializeComponent();
        }

        public KeyEditDialog(string type)
        {
            InitializeComponent();
            var data = type.Split('|');
            cboType.Text = data[0];
            if (data[0] == "Play Sound" && data.Count() > 1) txtPath.Text = data[1];
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (cboType.Text != "") DialogResult = DialogResult.OK;
            else pboOutline.Visible = true;
        }


        public string type;
        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = cboType.Text;
            pboOutline.Visible = false;
            type = cboType.Text;
            if (type == "Play Sound")
            {
                btnBrowse.Visible = true;
                txtPath.Visible = true;

            }
            else
            {
                btnBrowse.Visible = false;
                txtPath.Visible = false;
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            fileDialog.ShowDialog(this);
            txtPath.Text = fileDialog.FileName;
            type += "|" + fileDialog.FileName;
        }
    }
}
