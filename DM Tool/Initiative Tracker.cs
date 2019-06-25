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
    public partial class frmInitTracker : Form
    {
        public frmInitTracker()
        {
            InitializeComponent();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtName_MouseDown(object sender, MouseEventArgs e)
        {
            if (txtName.Text == "Character Name")
            {
                txtName.Text = "";
                txtName.ForeColor = Color.Black;
                txtName.Font = new Font(txtName.Font, FontStyle.Regular);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddInitiative(txtName.Text, (int)nudInitiative.Value);
            txtName.Text = "Character Name";
            txtName.ForeColor = Color.Silver;
            txtName.Font = new Font(txtName.Font, FontStyle.Italic);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            listInitiative.Items.Remove(listInitiative.SelectedItem);
        }

        private void frmInitTracker_MouseDown(object sender, MouseEventArgs e)
        {
            listInitiative.ClearSelected();
        }

        private void AddInitiative(string character, int initative)
        {
            listInitiative.Items.Add(initative + " - " + character);
            var unorderded = listInitiative.Items.Cast<string>().ToArray().Clone() as string[];
            listInitiative.Items.Clear();
            var items = unorderded.OrderByDescending(x => Convert.ToInt32(x.Split(new string[] { " - " }, StringSplitOptions.None)[0]));
            foreach (var item in items) listInitiative.Items.Add(item);
        }

        private void btnQuickAdd_Click(object sender, EventArgs e)
        {
            bool finish = false;
            do
            {
                InputDialog dialog = new InputDialog("Initiative Tracker Quick Add", "Character Name:", "Next", "End");
                int initiative;
                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    string character = dialog.ResultText;
                    dialog = new InputDialog("Initiative Tracker Quick Add", "Initiative:", "Next", null);
                    dialog.ShowDialog(this);
                    initiative = Convert.ToInt32(dialog.ResultText);
                    AddInitiative(character, initiative);
                }
                else
                {
                    dialog.Dispose();
                    finish = true;
                }
            } while (!finish);

        }
    }
}
