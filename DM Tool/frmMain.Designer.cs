namespace DM_Tool
{
    partial class frmMain
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
            this.btnInitTracker = new System.Windows.Forms.Button();
            this.lblDMTool = new System.Windows.Forms.Label();
            this.lblBrady = new System.Windows.Forms.Label();
            this.btnSoundPlayer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInitTracker
            // 
            this.btnInitTracker.Location = new System.Drawing.Point(145, 148);
            this.btnInitTracker.Name = "btnInitTracker";
            this.btnInitTracker.Size = new System.Drawing.Size(133, 23);
            this.btnInitTracker.TabIndex = 0;
            this.btnInitTracker.Text = "Initiative Tracker";
            this.btnInitTracker.UseVisualStyleBackColor = true;
            this.btnInitTracker.Click += new System.EventHandler(this.btnInitTracker_Click);
            // 
            // lblDMTool
            // 
            this.lblDMTool.AutoSize = true;
            this.lblDMTool.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDMTool.Location = new System.Drawing.Point(69, 33);
            this.lblDMTool.Name = "lblDMTool";
            this.lblDMTool.Size = new System.Drawing.Size(284, 76);
            this.lblDMTool.TabIndex = 1;
            this.lblDMTool.Text = "DM Tool";
            // 
            // lblBrady
            // 
            this.lblBrady.AutoSize = true;
            this.lblBrady.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrady.Location = new System.Drawing.Point(83, 30);
            this.lblBrady.Name = "lblBrady";
            this.lblBrady.Size = new System.Drawing.Size(55, 17);
            this.lblBrady.TabIndex = 2;
            this.lblBrady.Text = "Brady\'s";
            // 
            // btnSoundPlayer
            // 
            this.btnSoundPlayer.Location = new System.Drawing.Point(145, 178);
            this.btnSoundPlayer.Name = "btnSoundPlayer";
            this.btnSoundPlayer.Size = new System.Drawing.Size(133, 23);
            this.btnSoundPlayer.TabIndex = 3;
            this.btnSoundPlayer.Text = "Sound Player";
            this.btnSoundPlayer.UseVisualStyleBackColor = true;
            this.btnSoundPlayer.Click += new System.EventHandler(this.btnSoundPlayer_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 484);
            this.Controls.Add(this.btnSoundPlayer);
            this.Controls.Add(this.lblBrady);
            this.Controls.Add(this.lblDMTool);
            this.Controls.Add(this.btnInitTracker);
            this.Name = "frmMain";
            this.Text = "DM Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInitTracker;
        private System.Windows.Forms.Label lblDMTool;
        private System.Windows.Forms.Label lblBrady;
        private System.Windows.Forms.Button btnSoundPlayer;
    }
}

