using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using System.IO;

namespace DM_Tool
{
    public partial class frmSoundPlayer : Form
    {
        public frmSoundPlayer()
        {
            InitializeComponent();
        }

        //key: control, value: data
        Dictionary<string, string> keyBinds = new Dictionary<string, string>();
        Dictionary<string, Keys> ControlToKey = new Dictionary<string, Keys>
        {
            { "pboTilde", Keys.Oemtilde },
            { "pbo1", Keys.D1 },
            { "pbo2", Keys.D2 },
            { "pbo3", Keys.D3 },
            { "pbo4", Keys.D4 },
            { "pbo5", Keys.D5 },
            { "pbo6", Keys.D6 },
            { "pbo7", Keys.D7 },
            { "pbo8", Keys.D8 },
            { "pbo9", Keys.D9 },
            { "pbo0", Keys.D0 },
            { "pboMinus", Keys.OemMinus },
            { "pboPlus", Keys.Oemplus },
            { "pboQ", Keys.Q },
            { "pboW", Keys.W },
            { "pboE", Keys.E },
            { "pboR", Keys.R },
            { "pboT", Keys.T },
            { "pboY", Keys.Y },
            { "pboU", Keys.U },
            { "pboI", Keys.I },
            { "pboO", Keys.O },
            { "pboP", Keys.P },
            { "pboA", Keys.A },
            { "pboS", Keys.S },
            { "pboD", Keys.D },
            { "pboF", Keys.F },
            { "pboG", Keys.G },
            { "pboH", Keys.H },
            { "pboJ", Keys.J },
            { "pboK", Keys.K },
            { "pboL", Keys.L },
            { "pboZ", Keys.Z },
            { "pboX", Keys.X },
            { "pboC", Keys.C },
            { "pboV", Keys.V },
            { "pboB", Keys.B },
            { "pboN", Keys.N },
            { "pboM", Keys.M },
            { "pboColon", Keys.Oem1 },
            { "pboApostrophe", Keys.Oem7 },
            { "pboLShift", Keys.ShiftKey },
            { "pboComma", Keys.Oemcomma },
            { "pboPeriod", Keys.OemPeriod },
            { "pboSlash", Keys.OemQuestion },
            { "pboRShift", Keys.ShiftKey },
            { "pboBackSlash", Keys.Oem5 },
            { "pboLCTRL", Keys.ControlKey },
            { "pboLAlt", Keys.Menu },
            { "pboRAlt", Keys.Menu },
            { "pboSpace", Keys.Space },
            { "pboRCTRL", Keys.ControlKey },
            { "pboLeft", Keys.Left },
            { "pboUp", Keys.Up },
            { "pboDown", Keys.Down },
            { "pboRight", Keys.Right },
            { "pboInsert", Keys.Insert },
            { "pboDelete", Keys.Delete },
            { "pboHome", Keys.Home },
            { "pboEnd", Keys.End },
            { "pboPgUp", Keys.PageUp },
            { "pboPgDown", Keys.Next },
            { "pboNumLock", Keys.NumLock },
            { "pboNumSlash", Keys.Divide },
            { "pboNumAsterik", Keys.Multiply },
            { "pboNumMinus", Keys.Subtract },
            { "pboNum7", Keys.Home },
            { "pboNum8", Keys.Up },
            { "pboNum9", Keys.PageUp },
            { "pboNum4", Keys.Left },
            { "pboNum5", Keys.Clear },
            { "pboNum6", Keys.Right },
            { "pboNum1", Keys.End },
            { "pboNum2", Keys.Down },
            { "pboNum3", Keys.Next },
            { "pboNum0", Keys.Insert },
            { "pboNumPeriod", Keys.Delete },
            { "pboNumPlus", Keys.Add },
            { "pboNumEnter", Keys.Return }
        };
        Dictionary<Keys, string> KeyToControl = new Dictionary<Keys, string>()
        {
            { Keys.Oemtilde , "pboTilde" },
            { Keys.D1 , "pbo1" },
            { Keys.D2 , "pbo2" },
            { Keys.D3 , "pbo3" },
            { Keys.D4 , "pbo4" },
            { Keys.D5 , "pbo5" },
            { Keys.D6 , "pbo6" },
            { Keys.D7 , "pbo7" },
            { Keys.D8 , "pbo8" },
            { Keys.D9 , "pbo9" },
            { Keys.D0 , "pbo0" },
            { Keys.OemMinus , "pboMinus" },
            { Keys.Oemplus , "pboPlus" },
            { Keys.Q , "pboQ" },
            { Keys.W , "pboW" },
            { Keys.E , "pboE" },
            { Keys.R , "pboR" },
            { Keys.T , "pboT" },
            { Keys.Y , "pboY" },
            { Keys.U , "pboU" },
            { Keys.I , "pboI" },
            { Keys.O , "pboO" },
            { Keys.P , "pboP" },
            { Keys.A , "pboA" },
            { Keys.S , "pboS" },
            { Keys.D , "pboD" },
            { Keys.F , "pboF" },
            { Keys.G , "pboG" },
            { Keys.H , "pboH" },
            { Keys.J , "pboJ" },
            { Keys.K , "pboK" },
            { Keys.L , "pboL" },
            { Keys.Z , "pboZ" },
            { Keys.X , "pboX" },
            { Keys.C , "pboC" },
            { Keys.V , "pboV" },
            { Keys.B , "pboB" },
            { Keys.N , "pboN" },
            { Keys.M , "pboM" },
            { Keys.Oem1 , "pboColon" },
            { Keys.Oem7 , "pboApostrophe" },
            { Keys.ShiftKey , "pboLShift" }, //pboRShift
            { Keys.Oemcomma , "pboComma" },
            { Keys.OemPeriod , "pboPeriod" },
            { Keys.OemQuestion , "pboSlash" },
            { Keys.Oem5 , "pboBackSlash" },
            { Keys.Menu , "pboLAlt" }, //pboRAlt
            { Keys.Space , "pboSpace" },
            { Keys.ControlKey , "pboRCTRL" }, //but also LCTRL
            { Keys.Left , "pboLeft" }, //pboNum4
            { Keys.Up , "pboUp" }, //pboNum8
            { Keys.Down , "pboDown" }, //pboNum5
            { Keys.Right , "pboRight" }, //pboNum6
            { Keys.Insert , "pboInsert" }, //pboNum0
            { Keys.Delete , "pboDelete" }, //but also pboNumPeriod
            { Keys.Home , "pboHome" }, //but also pboNum7
            { Keys.End , "pboEnd" }, //pboNum1
            { Keys.PageUp , "pboPgUp" }, //pboNum4
            { Keys.Next , "pboPgDown" }, //pboNum3
            { Keys.NumLock , "pboNumLock" },
            { Keys.Divide , "pboNumSlash" },
            { Keys.Multiply , "pboNumAsterik" },
            { Keys.Subtract , "pboNumMinus" },
            { Keys.Clear , "pboNum5" },
            { Keys.Add , "pboNumPlus" },
            { Keys.Return , "pboNumEnter" }
        };

        private void pboKeyboard_Click(object sender, EventArgs e)
        {
            var buttons = Controls.Cast<Control>().Where(x => x.Name != "pboKeyboard" && x.GetType() == typeof(PictureBox));
            PictureBox clicked = null;
            Rectangle mouse = new Rectangle(PointToClient(Cursor.Position), new Size(1, 1));
            foreach (PictureBox pbo in buttons)
            {
                Rectangle r = new Rectangle(pbo.Location.X, pbo.Location.Y, pbo.Width, pbo.Height);
                if (r.IntersectsWith(mouse))
                {
                    clicked = pbo;
                    break;
                }
            }

            if (clicked != null)
            {
                string oldType;
                if (keyBinds.ContainsKey(clicked.Name)) oldType = keyBinds[clicked.Name];
                else oldType = null;

                KeyEditDialog keyEdit;
                if (oldType == null) keyEdit = new KeyEditDialog();
                else keyEdit = new KeyEditDialog(oldType);
                var result = keyEdit.ShowDialog();
                if (result == DialogResult.OK)
                {
                    var type = keyEdit.type;
                    if (keyBinds.ContainsKey(clicked.Name)) keyBinds[clicked.Name] = type;
                    else keyBinds.Add(clicked.Name, type);
                }

                keyEdit.Dispose();
                SaveData();
            }
        }


        Dictionary<Keys, MediaPlayer> mps = new Dictionary<Keys, MediaPlayer>();
        public void PlaySound(Keys k, string path)
        {
            if (!mps.ContainsKey(k))
            {
                mps.Add(k, new MediaPlayer());
                mps[k].Open(new Uri(path));
            }

            mps[k].Play();
        }

        //now that keys are mapped to controls, set chosen sound files to play on keypress

        private void frmSoundPlayer_KeyDown(object sender, KeyEventArgs e)
        {
            lblHelp.Text = $"You selected {e.KeyData}";
            if (keyBinds.ContainsKey(KeyToControl[e.KeyData]))
            {
                string data = keyBinds[KeyToControl[e.KeyData]];
                lblHelp.Text += $"\n{data}";
                var sData = data.Split('|');
                if (sData[0] == "Play Sound")
                {
                    PlaySound(e.KeyData, sData[1]);
                }
            }

        }

        private void SaveData()
        {
            string saveFile = "";
            foreach(var data in keyBinds)
            {
                saveFile += data.Key + "|" + data.Value;
            }
            File.WriteAllText("Resources/SPData",saveFile);
        }

        private void LoadData()
        {
            string[] saveFile = File.ReadAllLines("Resources/SPData");
            foreach(string data in saveFile)
            {
                var d = data.Split('|');
                keyBinds.Add(d[0], d[1] +"|"+ d[2]);
            }
        }

        private void frmSoundPlayer_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists("Resources")) Directory.CreateDirectory("Resources");
            LoadData();
        }
    }
}