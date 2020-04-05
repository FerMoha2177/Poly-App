namespace Final_Project
{
    partial class OathDialog
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
            this.oathControl1 = new Assignment3_Library.oathControl();
            this.SuspendLayout();
            // 
            // oathControl1
            // 
            this.oathControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.oathControl1.BackColor = System.Drawing.SystemColors.Highlight;
            this.oathControl1.Location = new System.Drawing.Point(160, 141);
            this.oathControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.oathControl1.Name = "oathControl1";
            this.oathControl1.Size = new System.Drawing.Size(570, 98);
            this.oathControl1.TabIndex = 3;
            // 
            // OathDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 529);
            this.Controls.Add(this.oathControl1);
            this.Name = "OathDialog";
            this.Text = "OathDialog";
            this.Controls.SetChildIndex(this.oathControl1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private Assignment3_Library.oathControl oathControl1;
    }
}