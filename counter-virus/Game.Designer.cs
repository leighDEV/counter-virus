namespace counter_virus
{
    partial class Game
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.txtAmmo = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.Label();
            this.healthBar = new System.Windows.Forms.ProgressBar();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.ptbHeart = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHeart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAmmo
            // 
            this.txtAmmo.AutoSize = true;
            this.txtAmmo.Font = new System.Drawing.Font("ArcadeClassic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmmo.ForeColor = System.Drawing.Color.White;
            this.txtAmmo.Location = new System.Drawing.Point(21, 15);
            this.txtAmmo.Name = "txtAmmo";
            this.txtAmmo.Size = new System.Drawing.Size(90, 23);
            this.txtAmmo.TabIndex = 0;
            this.txtAmmo.Text = "Ammo: 0";
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("ArcadeClassic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.ForeColor = System.Drawing.Color.White;
            this.txtScore.Location = new System.Drawing.Point(385, 15);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(96, 23);
            this.txtScore.TabIndex = 0;
            this.txtScore.Text = "Kills: 0";
            this.txtScore.Click += new System.EventHandler(this.txtScore_Click);
            // 
            // healthBar
            // 
            this.healthBar.Location = new System.Drawing.Point(731, 15);
            this.healthBar.Name = "healthBar";
            this.healthBar.Size = new System.Drawing.Size(172, 24);
            this.healthBar.TabIndex = 1;
            this.healthBar.Value = 100;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.MainTimer);
            // 
            // ptbHeart
            // 
            this.ptbHeart.BackColor = System.Drawing.Color.Transparent;
            this.ptbHeart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ptbHeart.Image = global::counter_virus.Properties.Resources.heart;
            this.ptbHeart.Location = new System.Drawing.Point(678, 6);
            this.ptbHeart.Name = "ptbHeart";
            this.ptbHeart.Size = new System.Drawing.Size(48, 41);
            this.ptbHeart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbHeart.TabIndex = 3;
            this.ptbHeart.TabStop = false;
            // 
            // player
            // 
            this.player.Image = global::counter_virus.Properties.Resources.player_up;
            this.player.Location = new System.Drawing.Point(386, 296);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(95, 77);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 2;
            this.player.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(924, 661);
            this.Controls.Add(this.healthBar);
            this.Controls.Add(this.ptbHeart);
            this.Controls.Add(this.player);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.txtAmmo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Counter Virus";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.ptbHeart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtAmmo;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.ProgressBar healthBar;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox ptbHeart;
    }
}

