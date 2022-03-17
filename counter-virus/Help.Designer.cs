namespace counter_virus
{
    partial class Help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help));
            this.btnHelpBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnHelpBack)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHelpBack
            // 
            this.btnHelpBack.BackColor = System.Drawing.Color.Transparent;
            this.btnHelpBack.Image = global::counter_virus.Properties.Resources.back;
            this.btnHelpBack.Location = new System.Drawing.Point(34, 430);
            this.btnHelpBack.Name = "btnHelpBack";
            this.btnHelpBack.Size = new System.Drawing.Size(104, 80);
            this.btnHelpBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHelpBack.TabIndex = 0;
            this.btnHelpBack.TabStop = false;
            this.btnHelpBack.Click += new System.EventHandler(this.btnHelpBack_Click);
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::counter_virus.Properties.Resources.help;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(740, 533);
            this.Controls.Add(this.btnHelpBack);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Help";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Help";
            ((System.ComponentModel.ISupportInitialize)(this.btnHelpBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnHelpBack;
    }
}