namespace Final_Project
{
    partial class TicTacToe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicTacToe));
            this.tictacMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pageSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playersBox = new System.Windows.Forms.GroupBox();
            this.player2LossesLabel = new System.Windows.Forms.Label();
            this.player1LossesLabel = new System.Windows.Forms.Label();
            this.player2winsLabel = new System.Windows.Forms.Label();
            this.player1winsLabel = new System.Windows.Forms.Label();
            this.player2Box = new System.Windows.Forms.GroupBox();
            this.player2Label = new System.Windows.Forms.Label();
            this.player1Box = new System.Windows.Forms.GroupBox();
            this.player1Label = new System.Windows.Forms.Label();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.timtactoeStatusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanelTicTacToe = new System.Windows.Forms.TableLayoutPanel();
            this.A2squareButton = new Final_Project.SquareButton();
            this.A3squareButton = new Final_Project.SquareButton();
            this.C3squareButton = new Final_Project.SquareButton();
            this.B1squareButton = new Final_Project.SquareButton();
            this.C2squareButton = new Final_Project.SquareButton();
            this.B2squareButton = new Final_Project.SquareButton();
            this.C1squareButton = new Final_Project.SquareButton();
            this.B3squareButton = new Final_Project.SquareButton();
            this.A1squareButton = new Final_Project.SquareButton();
            this.pageSetupDialog = new System.Windows.Forms.PageSetupDialog();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.gameCountLabel = new System.Windows.Forms.Label();
            this.buttonNewRound = new System.Windows.Forms.Button();
            this.tictacMenuStrip.SuspendLayout();
            this.playersBox.SuspendLayout();
            this.timtactoeStatusStrip.SuspendLayout();
            this.tableLayoutPanelTicTacToe.SuspendLayout();
            this.SuspendLayout();
            // 
            // tictacMenuStrip
            // 
            this.tictacMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tictacMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.tictacMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.tictacMenuStrip.Name = "tictacMenuStrip";
            this.tictacMenuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.tictacMenuStrip.Size = new System.Drawing.Size(825, 28);
            this.tictacMenuStrip.TabIndex = 0;
            this.tictacMenuStrip.Text = "tictacMenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.pageSetupToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.saveAsToolStripMenuItem.Text = "Save As";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.printPreviewToolStripMenuItem.Text = "Print Preview";
            this.printPreviewToolStripMenuItem.Click += new System.EventHandler(this.printPreviewToolStripMenuItem_Click);
            // 
            // pageSetupToolStripMenuItem
            // 
            this.pageSetupToolStripMenuItem.Name = "pageSetupToolStripMenuItem";
            this.pageSetupToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.pageSetupToolStripMenuItem.Text = "Page Setup";
            this.pageSetupToolStripMenuItem.Click += new System.EventHandler(this.pageSetupToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.preferencesToolStripMenuItem_Click);
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
            // playersBox
            // 
            this.playersBox.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.playersBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playersBox.Controls.Add(this.player2LossesLabel);
            this.playersBox.Controls.Add(this.player1LossesLabel);
            this.playersBox.Controls.Add(this.player2winsLabel);
            this.playersBox.Controls.Add(this.player1winsLabel);
            this.playersBox.Controls.Add(this.player2Box);
            this.playersBox.Controls.Add(this.player2Label);
            this.playersBox.Controls.Add(this.player1Box);
            this.playersBox.Controls.Add(this.player1Label);
            this.playersBox.Location = new System.Drawing.Point(23, 100);
            this.playersBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.playersBox.Name = "playersBox";
            this.playersBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.playersBox.Size = new System.Drawing.Size(307, 382);
            this.playersBox.TabIndex = 19;
            this.playersBox.TabStop = false;
            this.playersBox.Text = "Player: ";
            // 
            // player2LossesLabel
            // 
            this.player2LossesLabel.AutoSize = true;
            this.player2LossesLabel.Location = new System.Drawing.Point(6, 235);
            this.player2LossesLabel.Name = "player2LossesLabel";
            this.player2LossesLabel.Size = new System.Drawing.Size(24, 17);
            this.player2LossesLabel.TabIndex = 6;
            this.player2LossesLabel.Text = "L: ";
            // 
            // player1LossesLabel
            // 
            this.player1LossesLabel.AutoSize = true;
            this.player1LossesLabel.Location = new System.Drawing.Point(6, 76);
            this.player1LossesLabel.Name = "player1LossesLabel";
            this.player1LossesLabel.Size = new System.Drawing.Size(24, 17);
            this.player1LossesLabel.TabIndex = 5;
            this.player1LossesLabel.Text = "L: ";
            // 
            // player2winsLabel
            // 
            this.player2winsLabel.AutoSize = true;
            this.player2winsLabel.Location = new System.Drawing.Point(6, 203);
            this.player2winsLabel.Name = "player2winsLabel";
            this.player2winsLabel.Size = new System.Drawing.Size(29, 17);
            this.player2winsLabel.TabIndex = 4;
            this.player2winsLabel.Text = "W: ";
            // 
            // player1winsLabel
            // 
            this.player1winsLabel.AutoSize = true;
            this.player1winsLabel.Location = new System.Drawing.Point(6, 59);
            this.player1winsLabel.Name = "player1winsLabel";
            this.player1winsLabel.Size = new System.Drawing.Size(29, 17);
            this.player1winsLabel.TabIndex = 3;
            this.player1winsLabel.Text = "W: ";
            // 
            // player2Box
            // 
            this.player2Box.BackColor = System.Drawing.SystemColors.Control;
            this.player2Box.BackgroundImage = global::Final_Project.Properties.Resources.Tim_Downey2;
            this.player2Box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.player2Box.Location = new System.Drawing.Point(89, 166);
            this.player2Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.player2Box.Name = "player2Box";
            this.player2Box.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.player2Box.Size = new System.Drawing.Size(200, 100);
            this.player2Box.TabIndex = 2;
            this.player2Box.TabStop = false;
            this.player2Box.DragDrop += new System.Windows.Forms.DragEventHandler(this.Player2Box_DragDrop);
            this.player2Box.DragEnter += new System.Windows.Forms.DragEventHandler(this.Player2Box_DragEnter);
            // 
            // player2Label
            // 
            this.player2Label.Location = new System.Drawing.Point(6, 183);
            this.player2Label.Name = "player2Label";
            this.player2Label.Size = new System.Drawing.Size(186, 37);
            this.player2Label.TabIndex = 2;
            this.player2Label.Text = "Player 2";
            // 
            // player1Box
            // 
            this.player1Box.BackColor = System.Drawing.SystemColors.Control;
            this.player1Box.BackgroundImage = global::Final_Project.Properties.Resources.Tim_Downey;
            this.player1Box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.player1Box.Location = new System.Drawing.Point(89, 41);
            this.player1Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.player1Box.Name = "player1Box";
            this.player1Box.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.player1Box.Size = new System.Drawing.Size(200, 100);
            this.player1Box.TabIndex = 1;
            this.player1Box.TabStop = false;
            this.player1Box.DragDrop += new System.Windows.Forms.DragEventHandler(this.Player1Box_DragDrop);
            this.player1Box.DragEnter += new System.Windows.Forms.DragEventHandler(this.Player1Box_DragEnter);
            // 
            // player1Label
            // 
            this.player1Label.Location = new System.Drawing.Point(7, 41);
            this.player1Label.Name = "player1Label";
            this.player1Label.Size = new System.Drawing.Size(120, 37);
            this.player1Label.TabIndex = 0;
            this.player1Label.Text = "Player 1";
            // 
            // printDocument
            // 
            this.printDocument.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument_BeginPrint);
            this.printDocument.EndPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument_EndPrint);
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Document = this.printDocument;
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // timtactoeStatusStrip
            // 
            this.timtactoeStatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.timtactoeStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.timtactoeStatusStrip.Location = new System.Drawing.Point(0, 557);
            this.timtactoeStatusStrip.Name = "timtactoeStatusStrip";
            this.timtactoeStatusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.timtactoeStatusStrip.Size = new System.Drawing.Size(825, 25);
            this.timtactoeStatusStrip.TabIndex = 20;
            this.timtactoeStatusStrip.Text = "Winner";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(92, 20);
            this.toolStripStatusLabel.Text = "Game Status";
            // 
            // tableLayoutPanelTicTacToe
            // 
            this.tableLayoutPanelTicTacToe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelTicTacToe.ColumnCount = 3;
            this.tableLayoutPanelTicTacToe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.44398F));
            this.tableLayoutPanelTicTacToe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.27801F));
            this.tableLayoutPanelTicTacToe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.27801F));
            this.tableLayoutPanelTicTacToe.Controls.Add(this.A2squareButton, 1, 0);
            this.tableLayoutPanelTicTacToe.Controls.Add(this.A3squareButton, 2, 0);
            this.tableLayoutPanelTicTacToe.Controls.Add(this.C3squareButton, 2, 2);
            this.tableLayoutPanelTicTacToe.Controls.Add(this.B1squareButton, 0, 1);
            this.tableLayoutPanelTicTacToe.Controls.Add(this.C2squareButton, 1, 2);
            this.tableLayoutPanelTicTacToe.Controls.Add(this.B2squareButton, 1, 1);
            this.tableLayoutPanelTicTacToe.Controls.Add(this.C1squareButton, 0, 2);
            this.tableLayoutPanelTicTacToe.Controls.Add(this.B3squareButton, 2, 1);
            this.tableLayoutPanelTicTacToe.Controls.Add(this.A1squareButton, 0, 0);
            this.tableLayoutPanelTicTacToe.Location = new System.Drawing.Point(397, 100);
            this.tableLayoutPanelTicTacToe.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanelTicTacToe.Name = "tableLayoutPanelTicTacToe";
            this.tableLayoutPanelTicTacToe.RowCount = 3;
            this.tableLayoutPanelTicTacToe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelTicTacToe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelTicTacToe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelTicTacToe.Size = new System.Drawing.Size(335, 317);
            this.tableLayoutPanelTicTacToe.TabIndex = 21;
            this.tableLayoutPanelTicTacToe.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanelTicTacToe_Paint);
            // 
            // A2squareButton
            // 
            this.A2squareButton.BackColor = System.Drawing.SystemColors.Control;
            this.A2squareButton.BackImage = null;
            this.A2squareButton.ButtonText = "";
            this.A2squareButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.A2squareButton.Location = new System.Drawing.Point(114, 2);
            this.A2squareButton.Margin = new System.Windows.Forms.Padding(2);
            this.A2squareButton.Name = "A2squareButton";
            this.A2squareButton.Size = new System.Drawing.Size(107, 101);
            this.A2squareButton.TabIndex = 11;
            this.A2squareButton.Click += new System.EventHandler(this.square_click);
            this.A2squareButton.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanelTicTacToe_Paint);
            this.A2squareButton.Resize += new System.EventHandler(this.TicTacToe_Resize);
            // 
            // A3squareButton
            // 
            this.A3squareButton.BackColor = System.Drawing.SystemColors.Control;
            this.A3squareButton.BackImage = null;
            this.A3squareButton.ButtonText = "";
            this.A3squareButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.A3squareButton.Location = new System.Drawing.Point(225, 2);
            this.A3squareButton.Margin = new System.Windows.Forms.Padding(2);
            this.A3squareButton.Name = "A3squareButton";
            this.A3squareButton.Size = new System.Drawing.Size(108, 101);
            this.A3squareButton.TabIndex = 12;
            this.A3squareButton.Click += new System.EventHandler(this.square_click);
            this.A3squareButton.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanelTicTacToe_Paint);
            this.A3squareButton.Resize += new System.EventHandler(this.TicTacToe_Resize);
            // 
            // C3squareButton
            // 
            this.C3squareButton.BackColor = System.Drawing.SystemColors.Control;
            this.C3squareButton.BackImage = null;
            this.C3squareButton.ButtonText = "";
            this.C3squareButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.C3squareButton.Location = new System.Drawing.Point(226, 212);
            this.C3squareButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.C3squareButton.Name = "C3squareButton";
            this.C3squareButton.Size = new System.Drawing.Size(106, 103);
            this.C3squareButton.TabIndex = 18;
            this.C3squareButton.Click += new System.EventHandler(this.square_click);
            this.C3squareButton.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanelTicTacToe_Paint);
            this.C3squareButton.Resize += new System.EventHandler(this.TicTacToe_Resize);
            // 
            // B1squareButton
            // 
            this.B1squareButton.BackColor = System.Drawing.SystemColors.Control;
            this.B1squareButton.BackImage = null;
            this.B1squareButton.ButtonText = "";
            this.B1squareButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.B1squareButton.Location = new System.Drawing.Point(3, 107);
            this.B1squareButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.B1squareButton.Name = "B1squareButton";
            this.B1squareButton.Size = new System.Drawing.Size(106, 101);
            this.B1squareButton.TabIndex = 13;
            this.B1squareButton.Click += new System.EventHandler(this.square_click);
            this.B1squareButton.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanelTicTacToe_Paint);
            this.B1squareButton.Resize += new System.EventHandler(this.TicTacToe_Resize);
            // 
            // C2squareButton
            // 
            this.C2squareButton.BackColor = System.Drawing.SystemColors.Control;
            this.C2squareButton.BackImage = null;
            this.C2squareButton.ButtonText = "";
            this.C2squareButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.C2squareButton.Location = new System.Drawing.Point(115, 212);
            this.C2squareButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.C2squareButton.Name = "C2squareButton";
            this.C2squareButton.Size = new System.Drawing.Size(105, 103);
            this.C2squareButton.TabIndex = 17;
            this.C2squareButton.Click += new System.EventHandler(this.square_click);
            this.C2squareButton.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanelTicTacToe_Paint);
            this.C2squareButton.Resize += new System.EventHandler(this.TicTacToe_Resize);
            // 
            // B2squareButton
            // 
            this.B2squareButton.BackColor = System.Drawing.SystemColors.Control;
            this.B2squareButton.BackImage = null;
            this.B2squareButton.ButtonText = "";
            this.B2squareButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.B2squareButton.Location = new System.Drawing.Point(115, 107);
            this.B2squareButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.B2squareButton.Name = "B2squareButton";
            this.B2squareButton.Size = new System.Drawing.Size(105, 101);
            this.B2squareButton.TabIndex = 14;
            this.B2squareButton.Click += new System.EventHandler(this.square_click);
            this.B2squareButton.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanelTicTacToe_Paint);
            this.B2squareButton.Resize += new System.EventHandler(this.TicTacToe_Resize);
            // 
            // C1squareButton
            // 
            this.C1squareButton.BackColor = System.Drawing.SystemColors.Control;
            this.C1squareButton.BackImage = null;
            this.C1squareButton.ButtonText = "";
            this.C1squareButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.C1squareButton.Location = new System.Drawing.Point(3, 212);
            this.C1squareButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.C1squareButton.Name = "C1squareButton";
            this.C1squareButton.Size = new System.Drawing.Size(106, 103);
            this.C1squareButton.TabIndex = 16;
            this.C1squareButton.Click += new System.EventHandler(this.square_click);
            this.C1squareButton.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanelTicTacToe_Paint);
            this.C1squareButton.Resize += new System.EventHandler(this.TicTacToe_Resize);
            // 
            // B3squareButton
            // 
            this.B3squareButton.BackColor = System.Drawing.SystemColors.Control;
            this.B3squareButton.BackImage = null;
            this.B3squareButton.ButtonText = "";
            this.B3squareButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.B3squareButton.Location = new System.Drawing.Point(226, 107);
            this.B3squareButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.B3squareButton.Name = "B3squareButton";
            this.B3squareButton.Size = new System.Drawing.Size(106, 101);
            this.B3squareButton.TabIndex = 15;
            this.B3squareButton.Click += new System.EventHandler(this.square_click);
            this.B3squareButton.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanelTicTacToe_Paint);
            this.B3squareButton.Resize += new System.EventHandler(this.TicTacToe_Resize);
            // 
            // A1squareButton
            // 
            this.A1squareButton.BackColor = System.Drawing.SystemColors.Control;
            this.A1squareButton.BackImage = null;
            this.A1squareButton.ButtonText = "";
            this.A1squareButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.A1squareButton.Location = new System.Drawing.Point(2, 2);
            this.A1squareButton.Margin = new System.Windows.Forms.Padding(2);
            this.A1squareButton.Name = "A1squareButton";
            this.A1squareButton.Size = new System.Drawing.Size(108, 101);
            this.A1squareButton.TabIndex = 10;
            this.A1squareButton.Click += new System.EventHandler(this.square_click);
            this.A1squareButton.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanelTicTacToe_Paint);
            this.A1squareButton.Resize += new System.EventHandler(this.TicTacToe_Resize);
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // gameCountLabel
            // 
            this.gameCountLabel.AutoSize = true;
            this.gameCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameCountLabel.Location = new System.Drawing.Point(371, 48);
            this.gameCountLabel.Name = "gameCountLabel";
            this.gameCountLabel.Size = new System.Drawing.Size(103, 29);
            this.gameCountLabel.TabIndex = 22;
            this.gameCountLabel.Text = "Game #";
            // 
            // buttonNewRound
            // 
            this.buttonNewRound.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNewRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewRound.Location = new System.Drawing.Point(628, 450);
            this.buttonNewRound.Name = "buttonNewRound";
            this.buttonNewRound.Size = new System.Drawing.Size(104, 32);
            this.buttonNewRound.TabIndex = 23;
            this.buttonNewRound.Text = "Next Round";
            this.buttonNewRound.UseVisualStyleBackColor = true;
            this.buttonNewRound.Visible = false;
            this.buttonNewRound.Click += new System.EventHandler(this.buttonNewRound_Click);
            // 
            // TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(825, 582);
            this.Controls.Add(this.buttonNewRound);
            this.Controls.Add(this.tableLayoutPanelTicTacToe);
            this.Controls.Add(this.gameCountLabel);
            this.Controls.Add(this.timtactoeStatusStrip);
            this.Controls.Add(this.playersBox);
            this.Controls.Add(this.tictacMenuStrip);
            this.MainMenuStrip = this.tictacMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(843, 629);
            this.Name = "TicTacToe";
            this.Text = "TimTacToe";
            this.Load += new System.EventHandler(this.TicTacToe_Load);
            this.Resize += new System.EventHandler(this.TicTacToe_Resize);
            this.tictacMenuStrip.ResumeLayout(false);
            this.tictacMenuStrip.PerformLayout();
            this.playersBox.ResumeLayout(false);
            this.playersBox.PerformLayout();
            this.timtactoeStatusStrip.ResumeLayout(false);
            this.timtactoeStatusStrip.PerformLayout();
            this.tableLayoutPanelTicTacToe.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip tictacMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private SquareButton A1squareButton;
        private SquareButton A2squareButton;
        private SquareButton A3squareButton;
        private SquareButton B1squareButton;
        private SquareButton B2squareButton;
        private SquareButton B3squareButton;
        private SquareButton C1squareButton;
        private SquareButton C2squareButton;
        private SquareButton C3squareButton;
        private System.Windows.Forms.GroupBox playersBox;
        private System.Windows.Forms.Label player1Label;
        private System.Windows.Forms.Label player2Label;
        private System.Windows.Forms.GroupBox player1Box;
        private System.Windows.Forms.GroupBox player2Box;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.StatusStrip timtactoeStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTicTacToe;
        private System.Windows.Forms.ToolStripMenuItem pageSetupToolStripMenuItem;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.Label player2LossesLabel;
        private System.Windows.Forms.Label player1LossesLabel;
        private System.Windows.Forms.Label player2winsLabel;
        private System.Windows.Forms.Label player1winsLabel;
        private System.Windows.Forms.Label gameCountLabel;
        private System.Windows.Forms.Button buttonNewRound;
    }
}