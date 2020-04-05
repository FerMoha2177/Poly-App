namespace Final_Project
{
    partial class EmailApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmailApp));
            this.menuStripMail = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearCurrentEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripMail = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelEmail = new System.Windows.Forms.ToolStripStatusLabel();
            this.toLabel = new System.Windows.Forms.Label();
            this.fromLabel = new System.Windows.Forms.Label();
            this.messageLabel = new System.Windows.Forms.Label();
            this.subjectLabel = new System.Windows.Forms.Label();
            this.textBoxTo = new System.Windows.Forms.TextBox();
            this.textBoxSubject = new System.Windows.Forms.TextBox();
            this.textBoxFrom = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.helpProviderTo = new System.Windows.Forms.HelpProvider();
            this.helpProviderFrom = new System.Windows.Forms.HelpProvider();
            this.helpProviderSubject = new System.Windows.Forms.HelpProvider();
            this.helpProviderMessage = new System.Windows.Forms.HelpProvider();
            this.helpProviderSend = new System.Windows.Forms.HelpProvider();
            this.toolTipTo = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipFrom = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipSubject = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipMessage = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipSend = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipSaveDraft = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipViewDraft = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipClear = new System.Windows.Forms.ToolTip(this.components);
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.toolStripMail = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.helpProviderMsg = new System.Windows.Forms.HelpProvider();
            this.errorProviderMessage = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderSubject = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderFrom = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderTo = new System.Windows.Forms.ErrorProvider(this.components);
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.buttonSaveDraft = new System.Windows.Forms.Button();
            this.labelPriority = new System.Windows.Forms.Label();
            this.labelPriorityNumber = new System.Windows.Forms.Label();
            this.menuStripMail.SuspendLayout();
            this.statusStripMail.SuspendLayout();
            this.toolStripMail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripMail
            // 
            this.menuStripMail.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMail.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripMail.Location = new System.Drawing.Point(0, 0);
            this.menuStripMail.Name = "menuStripMail";
            this.menuStripMail.Padding = new System.Windows.Forms.Padding(5, 1, 0, 1);
            this.menuStripMail.Size = new System.Drawing.Size(779, 26);
            this.menuStripMail.TabIndex = 0;
            this.menuStripMail.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearCurrentEmailToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.saveasToolStripMenuItem,
            this.gridviewToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.fileToolStripMenuItem.Text = "Options";
            // 
            // clearCurrentEmailToolStripMenuItem
            // 
            this.clearCurrentEmailToolStripMenuItem.Name = "clearCurrentEmailToolStripMenuItem";
            this.clearCurrentEmailToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.clearCurrentEmailToolStripMenuItem.Text = "Clear Current Email";
            this.clearCurrentEmailToolStripMenuItem.ToolTipText = "Clear all text from email form";
            this.clearCurrentEmailToolStripMenuItem.Click += new System.EventHandler(this.clearCurrentEmailToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveasToolStripMenuItem
            // 
            this.saveasToolStripMenuItem.Name = "saveasToolStripMenuItem";
            this.saveasToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.saveasToolStripMenuItem.Text = "Save As";
            this.saveasToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // gridviewToolStripMenuItem
            // 
            this.gridviewToolStripMenuItem.Name = "gridviewToolStripMenuItem";
            this.gridviewToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.gridviewToolStripMenuItem.Text = "Grid View";
            this.gridviewToolStripMenuItem.Click += new System.EventHandler(this.gridviewToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveOnlyToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(118, 26);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(118, 26);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(118, 26);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStripMail
            // 
            this.statusStripMail.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStripMail.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelEmail});
            this.statusStripMail.Location = new System.Drawing.Point(0, 481);
            this.statusStripMail.Name = "statusStripMail";
            this.statusStripMail.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStripMail.Size = new System.Drawing.Size(779, 25);
            this.statusStripMail.TabIndex = 1;
            this.statusStripMail.Text = "Ready";
            // 
            // toolStripStatusLabelEmail
            // 
            this.toolStripStatusLabelEmail.Name = "toolStripStatusLabelEmail";
            this.toolStripStatusLabelEmail.Size = new System.Drawing.Size(50, 20);
            this.toolStripStatusLabelEmail.Text = "Ready";
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(29, 65);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(29, 17);
            this.toLabel.TabIndex = 2;
            this.toLabel.Text = "To:";
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Location = new System.Drawing.Point(29, 97);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(44, 17);
            this.fromLabel.TabIndex = 3;
            this.fromLabel.Text = "From:";
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(29, 171);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(69, 17);
            this.messageLabel.TabIndex = 4;
            this.messageLabel.Text = "Message:";
            // 
            // subjectLabel
            // 
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.Location = new System.Drawing.Point(29, 129);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(59, 17);
            this.subjectLabel.TabIndex = 5;
            this.subjectLabel.Text = "Subject:";
            // 
            // textBoxTo
            // 
            this.textBoxTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProviderTo.SetHelpString(this.textBoxTo, "Type the receiving email address.");
            this.textBoxTo.Location = new System.Drawing.Point(105, 64);
            this.textBoxTo.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.textBoxTo.Name = "textBoxTo";
            this.helpProviderTo.SetShowHelp(this.textBoxTo, true);
            this.textBoxTo.Size = new System.Drawing.Size(275, 22);
            this.textBoxTo.TabIndex = 6;
            this.toolTipTo.SetToolTip(this.textBoxTo, "Recipient");
            this.textBoxTo.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxTo_Validating);
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProviderSubject.SetHelpString(this.textBoxSubject, "Describe the contents of the email.");
            this.textBoxSubject.Location = new System.Drawing.Point(105, 132);
            this.textBoxSubject.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.textBoxSubject.Name = "textBoxSubject";
            this.helpProviderSubject.SetShowHelp(this.textBoxSubject, true);
            this.textBoxSubject.Size = new System.Drawing.Size(275, 22);
            this.textBoxSubject.TabIndex = 8;
            this.toolTipFrom.SetToolTip(this.textBoxSubject, "Description");
            this.textBoxSubject.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxSubject_Validating);
            // 
            // textBoxFrom
            // 
            this.textBoxFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProviderFrom.SetHelpString(this.textBoxFrom, "Type the sending email address.");
            this.textBoxFrom.Location = new System.Drawing.Point(105, 97);
            this.textBoxFrom.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.textBoxFrom.Name = "textBoxFrom";
            this.helpProviderFrom.SetShowHelp(this.textBoxFrom, true);
            this.textBoxFrom.Size = new System.Drawing.Size(275, 22);
            this.textBoxFrom.TabIndex = 7;
            this.toolTipFrom.SetToolTip(this.textBoxFrom, "Sender");
            this.textBoxFrom.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxFrom_Validating);
            // 
            // buttonSend
            // 
            this.buttonSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProviderSend.SetHelpString(this.buttonSend, "Click to send email.");
            this.buttonSend.Location = new System.Drawing.Point(565, 420);
            this.buttonSend.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.buttonSend.Name = "buttonSend";
            this.helpProviderSend.SetShowHelp(this.buttonSend, true);
            this.buttonSend.Size = new System.Drawing.Size(133, 37);
            this.buttonSend.TabIndex = 10;
            this.buttonSend.Text = "Send";
            this.toolTipSend.SetToolTip(this.buttonSend, "Send email");
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProviderMsg.SetHelpString(this.textBoxMessage, "Type email message");
            this.textBoxMessage.Location = new System.Drawing.Point(105, 170);
            this.textBoxMessage.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.helpProviderMsg.SetShowHelp(this.textBoxMessage, true);
            this.textBoxMessage.Size = new System.Drawing.Size(593, 229);
            this.textBoxMessage.TabIndex = 9;
            this.textBoxMessage.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxMessage_Validating);
            // 
            // toolStripMail
            // 
            this.toolStripMail.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripMail.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator,
            this.cutToolStripButton,
            this.copyToolStripButton,
            this.pasteToolStripButton,
            this.toolStripSeparator1});
            this.toolStripMail.Location = new System.Drawing.Point(0, 26);
            this.toolStripMail.Name = "toolStripMail";
            this.toolStripMail.Size = new System.Drawing.Size(779, 27);
            this.toolStripMail.TabIndex = 13;
            this.toolStripMail.Text = "toolStrip1";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.newToolStripButton.Text = "&New";
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.openToolStripButton.Text = "&Open";
            this.openToolStripButton.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveOnlyToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.cutToolStripButton.Text = "C&ut";
            this.cutToolStripButton.Click += new System.EventHandler(this.cutToolStripButton_Click);
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.copyToolStripButton.Text = "&Copy";
            this.copyToolStripButton.Click += new System.EventHandler(this.copyToolStripButton_Click);
            // 
            // pasteToolStripButton
            // 
            this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripButton.Image")));
            this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripButton.Name = "pasteToolStripButton";
            this.pasteToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.pasteToolStripButton.Text = "&Paste";
            this.pasteToolStripButton.Click += new System.EventHandler(this.pasteToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // errorProviderMessage
            // 
            this.errorProviderMessage.ContainerControl = this;
            // 
            // errorProviderSubject
            // 
            this.errorProviderSubject.ContainerControl = this;
            // 
            // errorProviderFrom
            // 
            this.errorProviderFrom.ContainerControl = this;
            // 
            // errorProviderTo
            // 
            this.errorProviderTo.ContainerControl = this;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // buttonSaveDraft
            // 
            this.buttonSaveDraft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSaveDraft.Location = new System.Drawing.Point(105, 420);
            this.buttonSaveDraft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSaveDraft.Name = "buttonSaveDraft";
            this.buttonSaveDraft.Size = new System.Drawing.Size(100, 28);
            this.buttonSaveDraft.TabIndex = 14;
            this.buttonSaveDraft.Text = "Save Draft";
            this.buttonSaveDraft.UseVisualStyleBackColor = true;
            this.buttonSaveDraft.Click += new System.EventHandler(this.buttonSaveDraft_Click);
            // 
            // labelPriority
            // 
            this.labelPriority.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPriority.AutoSize = true;
            this.labelPriority.Location = new System.Drawing.Point(581, 64);
            this.labelPriority.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPriority.Name = "labelPriority";
            this.labelPriority.Size = new System.Drawing.Size(56, 17);
            this.labelPriority.TabIndex = 15;
            this.labelPriority.Text = "Priority:";
            // 
            // labelPriorityNumber
            // 
            this.labelPriorityNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPriorityNumber.AutoSize = true;
            this.labelPriorityNumber.Location = new System.Drawing.Point(641, 64);
            this.labelPriorityNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPriorityNumber.Name = "labelPriorityNumber";
            this.labelPriorityNumber.Size = new System.Drawing.Size(16, 17);
            this.labelPriorityNumber.TabIndex = 16;
            this.labelPriorityNumber.Text = "0";
            // 
            // EmailApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(779, 506);
            this.Controls.Add(this.labelPriorityNumber);
            this.Controls.Add(this.labelPriority);
            this.Controls.Add(this.buttonSaveDraft);
            this.Controls.Add(this.toolStripMail);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.textBoxFrom);
            this.Controls.Add(this.textBoxSubject);
            this.Controls.Add(this.textBoxTo);
            this.Controls.Add(this.subjectLabel);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.statusStripMail);
            this.Controls.Add(this.menuStripMail);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMail;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(794, 543);
            this.Name = "EmailApp";
            this.Text = "Email Client";
            this.menuStripMail.ResumeLayout(false);
            this.menuStripMail.PerformLayout();
            this.statusStripMail.ResumeLayout(false);
            this.statusStripMail.PerformLayout();
            this.toolStripMail.ResumeLayout(false);
            this.toolStripMail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMail;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStripMail;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Label subjectLabel;
        private System.Windows.Forms.TextBox textBoxTo;
        private System.Windows.Forms.TextBox textBoxSubject;
        private System.Windows.Forms.TextBox textBoxFrom;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.HelpProvider helpProviderTo;
        private System.Windows.Forms.HelpProvider helpProviderFrom;
        private System.Windows.Forms.HelpProvider helpProviderSubject;
        private System.Windows.Forms.HelpProvider helpProviderMessage;
        private System.Windows.Forms.HelpProvider helpProviderSend;
        private System.Windows.Forms.ToolStripMenuItem clearCurrentEmailToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTipTo;
        private System.Windows.Forms.ToolTip toolTipFrom;
        private System.Windows.Forms.ToolTip toolTipSubject;
        private System.Windows.Forms.ToolTip toolTipMessage;
        private System.Windows.Forms.ToolTip toolTipSend;
        private System.Windows.Forms.ToolTip toolTipSaveDraft;
        private System.Windows.Forms.ToolTip toolTipViewDraft;
        private System.Windows.Forms.ToolTip toolTipClear;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.ToolStrip toolStripMail;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton cutToolStripButton;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripButton pasteToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.HelpProvider helpProviderMsg;
        private System.Windows.Forms.ErrorProvider errorProviderMessage;
        private System.Windows.Forms.ErrorProvider errorProviderSubject;
        private System.Windows.Forms.ErrorProvider errorProviderFrom;
        private System.Windows.Forms.ErrorProvider errorProviderTo;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelEmail;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveasToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem gridviewToolStripMenuItem;
        private System.Windows.Forms.Button buttonSaveDraft;
        private System.Windows.Forms.Label labelPriorityNumber;
        private System.Windows.Forms.Label labelPriority;
    }
}