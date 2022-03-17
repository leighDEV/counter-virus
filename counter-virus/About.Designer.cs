namespace counter_virus
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.btnAboutBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnAboutBack)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAboutBack
            // 
            this.btnAboutBack.BackColor = System.Drawing.Color.Transparent;
            this.btnAboutBack.Image = global::counter_virus.Properties.Resources.back;
            this.btnAboutBack.Location = new System.Drawing.Point(34, 431);
            this.btnAboutBack.Name = "btnAboutBack";
            this.btnAboutBack.Size = new System.Drawing.Size(104, 79);
            this.btnAboutBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAboutBack.TabIndex = 1;
            this.btnAboutBack.TabStop = false;
            this.btnAboutBack.Click += new System.EventHandler(this.btnAboutBack_Click);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::counter_virus.Properties.Resources.about;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(740, 533);
            this.Controls.Add(this.btnAboutBack);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.btnAboutBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnAboutBack;
    }
}