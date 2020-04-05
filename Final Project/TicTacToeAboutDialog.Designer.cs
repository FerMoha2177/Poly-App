namespace Final_Project
{
    partial class TicTacToeAboutDialog
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
            this.aboutDialogLabel.Location = new System.Drawing.Point(92, 97);
            this.aboutDialogLabel.Name = "aboutDialogLabel";
            this.aboutDialogLabel.Size = new System.Drawing.Size(728, 166);
            this.aboutDialogLabel.TabIndex = 3;
            this.aboutDialogLabel.Text = "About Dialog \r\nThis Application Allows user to play tic-tac-toe. The\r\nuser will b" +
    "e able to drag their own symbols that will\r\nserve as \"X\" or \"O\". The user will b" +
    "e able to print the \r\ngame as well. ";
            // 
            // TicTacToeAboutDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 529);
            this.Controls.Add(this.aboutDialogLabel);
            this.Name = "TicTacToeAboutDialog";
            this.Text = "TicTacToeAboutDialog";
            this.Controls.SetChildIndex(this.aboutDialogLabel, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label aboutDialogLabel;
    }
}