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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnInitTracker_Click(object sender, EventArgs e)
        {
            frmInitTracker frmInitTracker = new frmInitTracker();
            frmInitTracker.Show();
        }

        private void btnSoundPlayer_Click(object sender, EventArgs e)
        {
            frmSoundPlayer frmSoundPlayer = new frmSoundPlayer();
            frmSoundPlayer.Show();
        }
    }
}
