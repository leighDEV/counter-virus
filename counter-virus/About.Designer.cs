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
            this.btnAboutBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAboutBack
            // 
            this.btnAboutBack.Location = new System.Drawing.Point(43, 399);
            this.btnAboutBack.Name = "btnAboutBack";
            this.btnAboutBack.Size = new System.Drawing.Size(198, 69);
            this.btnAboutBack.TabIndex = 0;
            this.btnAboutBack.Text = "BACK TO HOME";
            this.btnAboutBack.UseVisualStyleBackColor = true;
            this.btnAboutBack.Click += new System.EventHandler(this.btnAboutBack_Click);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 500);
            this.Controls.Add(this.btnAboutBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAboutBack;
    }
}