namespace Final_Project
{
    partial class EmailDataGrid
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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewEmails = new System.Windows.Forms.DataGridView();
            this.labelPosition = new System.Windows.Forms.Label();
            this.labelOf = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonFont = new System.Windows.Forms.Button();
            this.textBoxPriority = new System.Windows.Forms.TextBox();
            this.labelFont = new System.Windows.Forms.Label();
            this.labelSetPriority = new System.Windows.Forms.Label();
            this.groupBoxEmailProperties = new System.Windows.Forms.GroupBox();
            this.bindingSourceEmail = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmails)).BeginInit();
            this.groupBoxEmailProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEmail)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEmails
            // 
            this.dataGridViewEmails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewEmails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmails.Location = new System.Drawing.Point(102, 38);
            this.dataGridViewEmails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewEmails.Name = "dataGridViewEmails";
            this.dataGridViewEmails.RowHeadersWidth = 51;
            this.dataGridViewEmails.RowTemplate.Height = 24;
            this.dataGridViewEmails.Size = new System.Drawing.Size(513, 224);
            this.dataGridViewEmails.TabIndex = 0;
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Location = new System.Drawing.Point(267, 12);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(24, 13);
            this.labelPosition.TabIndex = 50;
            this.labelPosition.Text = "pos";
            // 
            // labelOf
            // 
            this.labelOf.AutoSize = true;
            this.labelOf.Location = new System.Drawing.Point(291, 12);
            this.labelOf.Name = "labelOf";
            this.labelOf.Size = new System.Drawing.Size(16, 13);
            this.labelOf.TabIndex = 49;
            this.labelOf.Text = "of";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(308, 12);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(22, 13);
            this.labelCount.TabIndex = 48;
            this.labelCount.Text = "cnt";
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(381, 7);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(30, 23);
            this.buttonLast.TabIndex = 47;
            this.buttonLast.Text = ">|";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(336, 7);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(32, 23);
            this.buttonNext.TabIndex = 46;
            this.buttonNext.Text = ">";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Location = new System.Drawing.Point(230, 7);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(31, 23);
            this.buttonPrev.TabIndex = 45;
            this.buttonPrev.Text = "<";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonFirst
            // 
            this.buttonFirst.AutoSize = true;
            this.buttonFirst.Location = new System.Drawing.Point(180, 7);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(33, 23);
            this.buttonFirst.TabIndex = 44;
            this.buttonFirst.Text = "|<";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // buttonFont
            // 
            this.buttonFont.AutoSize = true;
            this.buttonFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFont.Location = new System.Drawing.Point(14, 18);
            this.buttonFont.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonFont.Name = "buttonFont";
            this.buttonFont.Size = new System.Drawing.Size(82, 30);
            this.buttonFont.TabIndex = 51;
            this.buttonFont.Text = "Set Font";
            this.buttonFont.UseVisualStyleBackColor = true;
            this.buttonFont.Click += new System.EventHandler(this.buttonFont_Click);
            // 
            // textBoxPriority
            // 
            this.textBoxPriority.Location = new System.Drawing.Point(91, 56);
            this.textBoxPriority.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPriority.Name = "textBoxPriority";
            this.textBoxPriority.Size = new System.Drawing.Size(25, 20);
            this.textBoxPriority.TabIndex = 53;
            // 
            // labelFont
            // 
            this.labelFont.AutoSize = true;
            this.labelFont.Location = new System.Drawing.Point(266, 36);
            this.labelFont.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFont.Name = "labelFont";
            this.labelFont.Size = new System.Drawing.Size(86, 13);
            this.labelFont.TabIndex = 54;
            this.labelFont.Text = "Example123!@#";
            // 
            // labelSetPriority
            // 
            this.labelSetPriority.AutoSize = true;
            this.labelSetPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSetPriority.Location = new System.Drawing.Point(11, 56);
            this.labelSetPriority.Name = "labelSetPriority";
            this.labelSetPriority.Size = new System.Drawing.Size(75, 16);
            this.labelSetPriority.TabIndex = 55;
            this.labelSetPriority.Text = "Set Priority:";
            // 
            // groupBoxEmailProperties
            // 
            this.groupBoxEmailProperties.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxEmailProperties.Controls.Add(this.labelSetPriority);
            this.groupBoxEmailProperties.Controls.Add(this.labelFont);
            this.groupBoxEmailProperties.Controls.Add(this.textBoxPriority);
            this.groupBoxEmailProperties.Controls.Add(this.buttonFont);
            this.groupBoxEmailProperties.Location = new System.Drawing.Point(103, 270);
            this.groupBoxEmailProperties.Name = "groupBoxEmailProperties";
            this.groupBoxEmailProperties.Size = new System.Drawing.Size(512, 81);
            this.groupBoxEmailProperties.TabIndex = 56;
            this.groupBoxEmailProperties.TabStop = false;
            this.groupBoxEmailProperties.Text = "Email Properties";
            // 
            // bindingSourceEmail
            // 
            this.bindingSourceEmail.DataSource = typeof(Final_Project.Email);
            // 
            // EmailDataGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 361);
            this.Controls.Add(this.groupBoxEmailProperties);
            this.Controls.Add(this.labelPosition);
            this.Controls.Add(this.labelOf);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.buttonFirst);
            this.Controls.Add(this.dataGridViewEmails);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EmailDataGrid";
            this.Text = "EmailDataGrid";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmails)).EndInit();
            this.groupBoxEmailProperties.ResumeLayout(false);
            this.groupBoxEmailProperties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEmail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEmails;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Label labelOf;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonFont;
        private System.Windows.Forms.TextBox textBoxPriority;
        private System.Windows.Forms.Label labelFont;
        private System.Windows.Forms.BindingSource bindingSourceEmail;
        private System.Windows.Forms.Label labelSetPriority;
        private System.Windows.Forms.GroupBox groupBoxEmailProperties;
    }
}