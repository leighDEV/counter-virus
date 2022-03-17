namespace counter_virus
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPlay.BackgroundImage = global::counter_virus.Properties.Resources.this_blue;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlay.Font = new System.Drawing.Font("ArcadeClassic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.NavajoWhite;
            this.btnPlay.Location = new System.Drawing.Point(365, 299);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(195, 57);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "PLAY";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnHelp.BackgroundImage = global::counter_virus.Properties.Resources.this_blue;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHelp.Font = new System.Drawing.Font("ArcadeClassic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.NavajoWhite;
            this.btnHelp.Location = new System.Drawing.Point(365, 373);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(195, 57);
            this.btnHelp.TabIndex = 0;
            this.btnHelp.Text = "HELP";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAbout.BackgroundImage = global::counter_virus.Properties.Resources.this_blue;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAbout.Font = new System.Drawing.Font("ArcadeClassic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.Color.NavajoWhite;
            this.btnAbout.Location = new System.Drawing.Point(365, 445);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(195, 57);
            this.btnAbout.TabIndex = 0;
            this.btnAbout.Text = "ABOUT";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnExit.BackgroundImage = global::counter_virus.Properties.Resources.this_blue;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("ArcadeClassic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.NavajoWhite;
            this.btnExit.Location = new System.Drawing.Point(365, 519);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(195, 57);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::counter_virus.Properties.Resources.menu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(924, 661);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnPlay);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Counter Virus";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnExit;
    }
}