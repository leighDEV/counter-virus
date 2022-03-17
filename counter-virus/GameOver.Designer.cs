namespace counter_virus
{
    partial class GameOver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameOver));
            this.btnPlayAgain = new System.Windows.Forms.PictureBox();
            this.btnBackToMenu = new System.Windows.Forms.PictureBox();
            this.showScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlayAgain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBackToMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.BackColor = System.Drawing.Color.Transparent;
            this.btnPlayAgain.Location = new System.Drawing.Point(148, 328);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(305, 70);
            this.btnPlayAgain.TabIndex = 0;
            this.btnPlayAgain.TabStop = false;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnBackToMenu.Location = new System.Drawing.Point(148, 426);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(305, 70);
            this.btnBackToMenu.TabIndex = 1;
            this.btnBackToMenu.TabStop = false;
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // showScore
            // 
            this.showScore.AutoSize = true;
            this.showScore.BackColor = System.Drawing.Color.Transparent;
            this.showScore.Font = new System.Drawing.Font("ArcadeClassic", 150F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showScore.ForeColor = System.Drawing.Color.Firebrick;
            this.showScore.Location = new System.Drawing.Point(149, 46);
            this.showScore.Name = "showScore";
            this.showScore.Size = new System.Drawing.Size(0, 199);
            this.showScore.TabIndex = 2;
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::counter_virus.Properties.Resources.gameover;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(590, 600);
            this.Controls.Add(this.showScore);
            this.Controls.Add(this.btnBackToMenu);
            this.Controls.Add(this.btnPlayAgain);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GameOver";
            this.Opacity = 0.5D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Over";
            ((System.ComponentModel.ISupportInitialize)(this.btnPlayAgain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBackToMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnPlayAgain;
        private System.Windows.Forms.PictureBox btnBackToMenu;
        private System.Windows.Forms.Label showScore;
    }
}