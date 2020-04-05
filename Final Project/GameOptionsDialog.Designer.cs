namespace Final_Project
{
    partial class GameOptionsDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameOptionsDialog));
            this.colorDialogTicTacToePreferences = new System.Windows.Forms.ColorDialog();
            this.buttonChangeBackgroundColor = new System.Windows.Forms.Button();
            this.buttonChangetImagePlayer1 = new System.Windows.Forms.Button();
            this.buttonChangetImagePlayer2 = new System.Windows.Forms.Button();
            this.buttonApplySettings = new System.Windows.Forms.Button();
            this.panelBackgroundColorExample = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBoxPlayerImages = new System.Windows.Forms.GroupBox();
            this.groupBoxColors = new System.Windows.Forms.GroupBox();
            this.panelLineColorExample = new System.Windows.Forms.Panel();
            this.buttonChangeLineColor = new System.Windows.Forms.Button();
            this.groupBoxPlayerImages.SuspendLayout();
            this.groupBoxColors.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonChangeBackgroundColor
            // 
            this.buttonChangeBackgroundColor.AutoSize = true;
            this.buttonChangeBackgroundColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangeBackgroundColor.Location = new System.Drawing.Point(6, 19);
            this.buttonChangeBackgroundColor.Name = "buttonChangeBackgroundColor";
            this.buttonChangeBackgroundColor.Size = new System.Drawing.Size(194, 28);
            this.buttonChangeBackgroundColor.TabIndex = 1;
            this.buttonChangeBackgroundColor.Text = "Change Background Color";
            this.buttonChangeBackgroundColor.UseVisualStyleBackColor = true;
            this.buttonChangeBackgroundColor.Click += new System.EventHandler(this.buttonChangeBackgroundColor_Click);
            // 
            // buttonChangetImagePlayer1
            // 
            this.buttonChangetImagePlayer1.AutoSize = true;
            this.buttonChangetImagePlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangetImagePlayer1.Location = new System.Drawing.Point(6, 19);
            this.buttonChangetImagePlayer1.Name = "buttonChangetImagePlayer1";
            this.buttonChangetImagePlayer1.Size = new System.Drawing.Size(170, 28);
            this.buttonChangetImagePlayer1.TabIndex = 2;
            this.buttonChangetImagePlayer1.Text = "Change Player 1 Image";
            this.buttonChangetImagePlayer1.UseVisualStyleBackColor = true;
            this.buttonChangetImagePlayer1.Click += new System.EventHandler(this.buttonChangetImagePlayer1_Click);
            // 
            // buttonChangetImagePlayer2
            // 
            this.buttonChangetImagePlayer2.AutoSize = true;
            this.buttonChangetImagePlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangetImagePlayer2.Location = new System.Drawing.Point(6, 142);
            this.buttonChangetImagePlayer2.Name = "buttonChangetImagePlayer2";
            this.buttonChangetImagePlayer2.Size = new System.Drawing.Size(170, 28);
            this.buttonChangetImagePlayer2.TabIndex = 3;
            this.buttonChangetImagePlayer2.Text = "Change Player 2 Image";
            this.buttonChangetImagePlayer2.UseVisualStyleBackColor = true;
            this.buttonChangetImagePlayer2.Click += new System.EventHandler(this.buttonChangetImagePlayer2_Click);
            // 
            // buttonApplySettings
            // 
            this.buttonApplySettings.AutoSize = true;
            this.buttonApplySettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApplySettings.Location = new System.Drawing.Point(75, 129);
            this.buttonApplySettings.Name = "buttonApplySettings";
            this.buttonApplySettings.Size = new System.Drawing.Size(110, 28);
            this.buttonApplySettings.TabIndex = 4;
            this.buttonApplySettings.Text = "Apply";
            this.buttonApplySettings.UseVisualStyleBackColor = true;
            this.buttonApplySettings.Click += new System.EventHandler(this.buttonApplySettings_Click);
            // 
            // panelBackgroundColorExample
            // 
            this.panelBackgroundColorExample.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBackgroundColorExample.Location = new System.Drawing.Point(206, 19);
            this.panelBackgroundColorExample.Name = "panelBackgroundColorExample";
            this.panelBackgroundColorExample.Size = new System.Drawing.Size(25, 25);
            this.panelBackgroundColorExample.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::Final_Project.Properties.Resources.Tim_Downey;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Location = new System.Drawing.Point(182, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(118, 117);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Player 1";
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = global::Final_Project.Properties.Resources.Tim_Downey2;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Location = new System.Drawing.Point(182, 142);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(118, 117);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Player 2";
            // 
            // groupBoxPlayerImages
            // 
            this.groupBoxPlayerImages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxPlayerImages.Controls.Add(this.buttonChangetImagePlayer1);
            this.groupBoxPlayerImages.Controls.Add(this.groupBox2);
            this.groupBoxPlayerImages.Controls.Add(this.groupBox1);
            this.groupBoxPlayerImages.Controls.Add(this.buttonChangetImagePlayer2);
            this.groupBoxPlayerImages.Location = new System.Drawing.Point(272, 12);
            this.groupBoxPlayerImages.Name = "groupBoxPlayerImages";
            this.groupBoxPlayerImages.Size = new System.Drawing.Size(314, 272);
            this.groupBoxPlayerImages.TabIndex = 8;
            this.groupBoxPlayerImages.TabStop = false;
            this.groupBoxPlayerImages.Text = "Images";
            // 
            // groupBoxColors
            // 
            this.groupBoxColors.Controls.Add(this.panelLineColorExample);
            this.groupBoxColors.Controls.Add(this.buttonChangeLineColor);
            this.groupBoxColors.Controls.Add(this.buttonChangeBackgroundColor);
            this.groupBoxColors.Controls.Add(this.panelBackgroundColorExample);
            this.groupBoxColors.Location = new System.Drawing.Point(12, 12);
            this.groupBoxColors.Name = "groupBoxColors";
            this.groupBoxColors.Size = new System.Drawing.Size(244, 100);
            this.groupBoxColors.TabIndex = 9;
            this.groupBoxColors.TabStop = false;
            this.groupBoxColors.Text = "Board Colors";
            // 
            // panelLineColorExample
            // 
            this.panelLineColorExample.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLineColorExample.Location = new System.Drawing.Point(206, 66);
            this.panelLineColorExample.Name = "panelLineColorExample";
            this.panelLineColorExample.Size = new System.Drawing.Size(25, 25);
            this.panelLineColorExample.TabIndex = 6;
            // 
            // buttonChangeLineColor
            // 
            this.buttonChangeLineColor.AutoSize = true;
            this.buttonChangeLineColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangeLineColor.Location = new System.Drawing.Point(6, 66);
            this.buttonChangeLineColor.Name = "buttonChangeLineColor";
            this.buttonChangeLineColor.Size = new System.Drawing.Size(194, 28);
            this.buttonChangeLineColor.TabIndex = 6;
            this.buttonChangeLineColor.Text = "Change Line Color";
            this.buttonChangeLineColor.UseVisualStyleBackColor = true;
            this.buttonChangeLineColor.Click += new System.EventHandler(this.buttonChangeLineColor_Click);
            // 
            // GameOptionsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 311);
            this.Controls.Add(this.groupBoxColors);
            this.Controls.Add(this.groupBoxPlayerImages);
            this.Controls.Add(this.buttonApplySettings);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(640, 350);
            this.Name = "GameOptionsDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "GameOptionsDialog";
            this.groupBoxPlayerImages.ResumeLayout(false);
            this.groupBoxPlayerImages.PerformLayout();
            this.groupBoxColors.ResumeLayout(false);
            this.groupBoxColors.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialogTicTacToePreferences;
        private System.Windows.Forms.Button buttonChangeBackgroundColor;
        private System.Windows.Forms.Button buttonChangetImagePlayer1;
        private System.Windows.Forms.Button buttonChangetImagePlayer2;
        private System.Windows.Forms.Button buttonApplySettings;
        private System.Windows.Forms.Panel panelBackgroundColorExample;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBoxPlayerImages;
        private System.Windows.Forms.GroupBox groupBoxColors;
        private System.Windows.Forms.Button buttonChangeLineColor;
        private System.Windows.Forms.Panel panelLineColorExample;
    }
}