namespace Final_Project
{
    partial class FibonacciCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FibonacciCalculator));
            this.label1 = new System.Windows.Forms.Label();
            this.numberAnswerSpace = new System.Windows.Forms.Label();
            this.Calculate = new System.Windows.Forms.Button();
            this.fibonacciAnswerTextBox = new System.Windows.Forms.TextBox();
            this.fibonacciNValueNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.fibonacciCalculationToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.fibonacciCalculationToolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.fibonacciNValueNumericUpDown)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Value of n:";
            // 
            // numberAnswerSpace
            // 
            this.numberAnswerSpace.AutoSize = true;
            this.numberAnswerSpace.Location = new System.Drawing.Point(80, 86);
            this.numberAnswerSpace.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.numberAnswerSpace.Name = "numberAnswerSpace";
            this.numberAnswerSpace.Size = new System.Drawing.Size(0, 17);
            this.numberAnswerSpace.TabIndex = 3;
            // 
            // Calculate
            // 
            this.Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.Calculate.Location = new System.Drawing.Point(257, 14);
            this.Calculate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(113, 35);
            this.Calculate.TabIndex = 4;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // fibonacciAnswerTextBox
            // 
            this.fibonacciAnswerTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fibonacciAnswerTextBox.Location = new System.Drawing.Point(0, 72);
            this.fibonacciAnswerTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fibonacciAnswerTextBox.Multiline = true;
            this.fibonacciAnswerTextBox.Name = "fibonacciAnswerTextBox";
            this.fibonacciAnswerTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.fibonacciAnswerTextBox.Size = new System.Drawing.Size(451, 163);
            this.fibonacciAnswerTextBox.TabIndex = 5;
            // 
            // fibonacciNValueNumericUpDown
            // 
            this.fibonacciNValueNumericUpDown.Location = new System.Drawing.Point(163, 20);
            this.fibonacciNValueNumericUpDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fibonacciNValueNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.fibonacciNValueNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.fibonacciNValueNumericUpDown.Name = "fibonacciNValueNumericUpDown";
            this.fibonacciNValueNumericUpDown.Size = new System.Drawing.Size(80, 22);
            this.fibonacciNValueNumericUpDown.TabIndex = 6;
            this.fibonacciNValueNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fibonacciCalculationToolStripStatusLabel,
            this.fibonacciCalculationToolStripProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 223);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
            this.statusStrip1.Size = new System.Drawing.Size(451, 26);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // fibonacciCalculationToolStripStatusLabel
            // 
            this.fibonacciCalculationToolStripStatusLabel.Name = "fibonacciCalculationToolStripStatusLabel";
            this.fibonacciCalculationToolStripStatusLabel.Size = new System.Drawing.Size(50, 20);
            this.fibonacciCalculationToolStripStatusLabel.Text = "Ready";
            // 
            // fibonacciCalculationToolStripProgressBar
            // 
            this.fibonacciCalculationToolStripProgressBar.Name = "fibonacciCalculationToolStripProgressBar";
            this.fibonacciCalculationToolStripProgressBar.Size = new System.Drawing.Size(67, 18);
            this.fibonacciCalculationToolStripProgressBar.Visible = false;
            // 
            // FibonacciCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 249);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.fibonacciNValueNumericUpDown);
            this.Controls.Add(this.fibonacciAnswerTextBox);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.numberAnswerSpace);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FibonacciCalculator";
            this.Text = "Calculate the nth Fibonacci number";
            ((System.ComponentModel.ISupportInitialize)(this.fibonacciNValueNumericUpDown)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label numberAnswerSpace;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.TextBox fibonacciAnswerTextBox;
        private System.Windows.Forms.NumericUpDown fibonacciNValueNumericUpDown;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel fibonacciCalculationToolStripStatusLabel;
        private System.Windows.Forms.ToolStripProgressBar fibonacciCalculationToolStripProgressBar;
    }
}