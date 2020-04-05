namespace Final_Project
{
    partial class EmailAboutDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmailAboutDialog));
            this.labelEmailAbout = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelEmailAbout
            // 
            this.labelEmailAbout.AutoSize = true;
            this.labelEmailAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmailAbout.Location = new System.Drawing.Point(-5, 126);
            this.labelEmailAbout.Name = "labelEmailAbout";
            this.labelEmailAbout.Size = new System.Drawing.Size(764, 116);
            this.labelEmailAbout.TabIndex = 2;
            this.labelEmailAbout.Text = "Use this client to send email messages!\r\nSpecify the sending and receiving emails" +
    " along with the subject. \r\nClick the send button to send the email!\r\nThis client" +
    " uses smtp.gmail.com.";
            // 
            // EmailAboutDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelEmailAbout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmailAboutDialog";
            this.Text = "EmailAboutDialog";
            this.Controls.SetChildIndex(this.labelEmailAbout, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEmailAbout;
    }
}