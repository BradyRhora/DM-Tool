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
    public partial class InputDialog : Form
    {
        public string ResultText;

        public InputDialog(string title, string message, string buttonTxt = "", string cancelButtonTxt = "")
        {
            InitializeComponent();
            Text = title;
            lblText.Text = message;
            lblText.Left = (Width/2)-(lblText.Width/2);
            if (buttonTxt != "") btnConfirm.Text = buttonTxt;
            if (cancelButtonTxt == null) btnCancel.Visible = false;
            else if (cancelButtonTxt != "") btnCancel.Text = cancelButtonTxt;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            ResultText = txtInput.Text;
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
