namespace Final_Project
{
    partial class AboutDialog
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
            this.aboutDialogLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // aboutDialogLabel
            // 
            this.aboutDialogLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutDialogLabel.ForeColor = System.Drawing.Color.Maroon;
            this.aboutDialogLabel.Location = new System.Drawing.Point(43, 76);
            this.aboutDialogLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.aboutDialogLabel.Name = "aboutDialogLabel";
            this.aboutDialogLabel.Size = new System.Drawing.Size(546, 135);
            this.aboutDialogLabel.TabIndex = 2;
            this.aboutDialogLabel.Text = "About Dialog \r\nThis Application Allows the user to play TimTacToe™, calculate fib" +
    "onacci and also has an Email client! (email client can only send emails)\r\n";
            // 
            // AboutDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 430);
            this.Controls.Add(this.aboutDialogLabel);
            this.Name = "AboutDialog";
            this.Text = "AboutDialog";
            this.Controls.SetChildIndex(this.aboutDialogLabel, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label aboutDialogLabel;
    }
}