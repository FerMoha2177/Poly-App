using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Drawing.Drawing2D;

namespace Final_Project
{
    public partial class TicTacToe : Form
    {
        bool turn = true;   // current turn
        int turnCount = 0; // number of turns
        int PageCounter = 0;
        int gameCount = 1;
        List<SquareButton> squares = new List<SquareButton>(); // list of square buttons on form
        Bitmap imagePlayer1 = ((System.Drawing.Bitmap)(Properties.Resources.Tim_Downey));
        Bitmap imagePlayer2 = ((System.Drawing.Bitmap)(Properties.Resources.Tim_Downey2));
        Bitmap memoryImage;
        List<Bitmap> memoryImages;
        bool preview;
        Font printerfont;
        int player1wins;
        int player2wins;
        int player1losses;
        int player2losses;
        Pen pen = new Pen(Color.Red, 15.0f);



        public TicTacToe()
        {

            InitializeComponent();
            squares = new List<SquareButton>();
            squares.Add(A1squareButton);
            squares.Add(A2squareButton);
            squares.Add(A3squareButton);
            squares.Add(B1squareButton);
            squares.Add(B2squareButton);
            squares.Add(B3squareButton);
            squares.Add(C1squareButton);
            squares.Add(C2squareButton);
            squares.Add(C3squareButton);

            this.printPreviewDialog = new PrintPreviewDialog();
            this.pageSetupDialog = new PageSetupDialog();
            this.printDialog = new PrintDialog();
            this.toolStripStatusLabel.Text = "Player 1 Turn";
            memoryImages = new List<Bitmap>();
            gameCountLabel.Text = "Game #" + gameCount.ToString();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TicTacToeAboutDialog aboutDialog = new TicTacToeAboutDialog();
            aboutDialog.Show();
        }

        private void square_click(object sender, EventArgs e)
        {
            SquareButton square = (SquareButton)sender;
            if (turn)
            {
                square.BackgroundImage = imagePlayer1;
                square.BackgroundImageLayout = ImageLayout.Stretch;

                square.ButtonText = "X";
                this.toolStripStatusLabel.Text = "Player 2 Turn";
            }
            else
            {
                square.BackgroundImage = imagePlayer2;
                //square.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Tim_Downey2));
                square.BackgroundImageLayout = ImageLayout.Stretch;

                square.ButtonText = "O";
                this.toolStripStatusLabel.Text = "Player 1 Turn";
            }

            turn = !turn;
            turnCount++;
            square.Enabled = false;

            checkForWinner();
            CaptureForm();
        }

        //clear board

        private void ClearBoard()
        {
            foreach (SquareButton square in squares)
            {
                square.BackgroundImage = null;
                square.ButtonText = "";
            }
        }

        private void NewGame()
        {
            ClearBoard();
            EnableSquares();
            turnCount = 0;
            gameCount++;
            gameCountLabel.Text = "Game #" + gameCount.ToString();
            turn = true;
        }

        bool isWinner = false;

        bool isWinnerVertical1, isWinnerVertical2, isWinnerVertical3;
        bool isWinnerHorizontalA , isWinnerHorizontalB , isWinnerHorizontalC;
        bool isWinnerDiagonalLeft, isWinnerDiagonalRight;

        private void checkForWinner()
        {

            isWinner = isWinnerVertical1 = isWinnerVertical2 =  isWinnerVertical3 = false;
            isWinnerHorizontalA = isWinnerHorizontalB = isWinnerHorizontalC = false;
            isWinnerDiagonalLeft = isWinnerDiagonalRight = false;

            // Check horizontally
            if ((A1squareButton.ButtonText == A2squareButton.ButtonText) && (A2squareButton.ButtonText == A3squareButton.ButtonText)
                && (!A1squareButton.Enabled))
            {
                isWinner = true;
                isWinnerHorizontalA = true;

            }
            else if((B1squareButton.ButtonText == B2squareButton.ButtonText) && (B2squareButton.ButtonText == B3squareButton.ButtonText)
                && (!B1squareButton.Enabled))
            {
                isWinner = true;
                isWinnerHorizontalB = true;

            }
            else if ((C1squareButton.ButtonText == C2squareButton.ButtonText) && (C2squareButton.ButtonText == C3squareButton.ButtonText)
                && (!C1squareButton.Enabled))
            {
                isWinner = true;
                isWinnerHorizontalC = true;
            }

            // Checks Vertically
            if ((A1squareButton.ButtonText == B1squareButton.ButtonText) && (B1squareButton.ButtonText == C1squareButton.ButtonText)
                && (!A1squareButton.Enabled))
            {
                isWinner = true;
                isWinnerVertical1 = true;
            }
            else if ((A2squareButton.ButtonText == B2squareButton.ButtonText) && (B2squareButton.ButtonText == C2squareButton.ButtonText)
               && (!A2squareButton.Enabled))
            {
                isWinner = true;
                isWinnerVertical2 = true;
            }
            else if ((A3squareButton.ButtonText == B3squareButton.ButtonText) && (B3squareButton.ButtonText == C3squareButton.ButtonText)
               && (!A3squareButton.Enabled))
            {
                isWinner = true;
                isWinnerVertical3 = true;

            }

            // diagonal checks
            if ((A1squareButton.ButtonText == B2squareButton.ButtonText) && (B2squareButton.ButtonText == C3squareButton.ButtonText)
                && (!A1squareButton.Enabled))
            {
                isWinner = true;
                isWinnerDiagonalLeft = true;
            }

            else if ((A3squareButton.ButtonText == B2squareButton.ButtonText) && (B2squareButton.ButtonText == C1squareButton.ButtonText)
               && (!A3squareButton.Enabled))
            {
                isWinner = true;
                isWinnerDiagonalRight = true;
            }


            if (isWinner)
            {
                disableSquares();
                //this.timtactoeStatusStrip.Text = "Show Winner Name";
                string winnerMessage;

                //we could just make this into a help method 
                if (turnCount %2 == 0)
                {
                    //player 2 won
                    player2wins++;
                    player1losses++;
                    winnerMessage = "Player 2 Wins!";
                    player2winsLabel.Text = "W: " + player2wins.ToString();
                    player1LossesLabel.Text = "L: " + player1losses.ToString();


                    this.toolStripStatusLabel.Text = winnerMessage;
                }
                else
                {
                    //player 1 won
                    player1wins++;
                    player2losses++;
                    winnerMessage = "Player 1 Wins!";
                    player1winsLabel.Text = "W: " + player1wins.ToString();
                    player2LossesLabel.Text = "L: " + player2losses.ToString();

                    this.toolStripStatusLabel.Text = winnerMessage;
                }
                ShowLineOnInvalidate();
                buttonNewRound.Visible = true;
            }

            else if(turnCount == 9)
            {
                this.toolStripStatusLabel.Text = "Draw!";
                buttonNewRound.Visible = true;
            }

        }

        
        private void disableSquares()
        {
            foreach(SquareButton sqaure in squares)
            {
                sqaure.Enabled = false;
            }
        }

        private void EnableSquares()
        {
            foreach (SquareButton sqaure in squares)
            {
                sqaure.Enabled = true;
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TicTacToe().Show();
            this.Close();
        }

        
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int page = 0;
            int maxPage = 0;
            CaptureForm();
            
            try
            {
                int totalPages = memoryImages.Count;
                this.printDocument.PrinterSettings.FromPage = 1;
                this.printDocument.PrinterSettings.ToPage = totalPages;
                this.printDocument.PrinterSettings.MinimumPage = 1;
                this.printDocument.PrinterSettings.MaximumPage = totalPages;
                this.printDialog.AllowSomePages = true;
                this.printDialog.Document = this.printDocument;
                if (this.printDialog.ShowDialog() == DialogResult.OK)
                {
                    if (this.printDialog.PrinterSettings.PrintRange ==
                                                                 PrintRange.SomePages)
                    {
                        // Set first page to print to FromPage
                        page = this.printDocument.PrinterSettings.FromPage;
                        // Set last page to print to ToPage
                        maxPage = this.printDocument.PrinterSettings.ToPage;
                    }
                    else
                    {
                        // Print all pages
                        page = 1;
                        maxPage = totalPages;
                    }
                    this.printDocument.DocumentName = "TimTacToe";
                    this.printDocument.Print();
                }

            }
            catch
            {
                MessageBox.Show("Unable to print for some reason");
            }        
        }

        //The PrintPage event is triggered by a call to the PrintDocument
        //object's Print method.
        void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Draw to the e.Graphics object that wraps the print target
            Graphics g = e.Graphics;

            // Get the real page bounds
            Rectangle realPageBounds = GetRealPageBounds(e, preview);

            //Font printerfont = new Font("Lucida Console", 25);
            StringFormat centerFormat = new StringFormat();
            centerFormat.Alignment = StringAlignment.Center;
            centerFormat.LineAlignment = StringAlignment.Far;


            StringFormat centerFormat2 = new StringFormat();
            centerFormat2.Alignment = StringAlignment.Center;
            centerFormat2.LineAlignment = StringAlignment.Near;

            // Draw a header in the upper left
            g.DrawString("Advanced Windows Programming Project", printerfont, Brushes.Black, realPageBounds, centerFormat2);


            // Draw a footer in the lower right
            
            g.DrawString(
            "Copyright @ 2019 Team 6",
            printerfont,
            Brushes.Black,
            realPageBounds,
            centerFormat);


            RectangleF realMarginBounds = GetRealMarginBounds(e, preview);
            g.DrawImage(memoryImages[PageCounter], realMarginBounds);
            PageCounter++;
            e.HasMorePages = (PageCounter != memoryImages.Count);
        }

        // Get real page bounds based on printable area of the page
        static Rectangle GetRealPageBounds(PrintPageEventArgs e, bool preview)
        {
            // Return in units of 1/100 inch
            if (preview) return e.PageBounds;
            // Translate to units of 1/100 inch
            RectangleF vpb = e.Graphics.VisibleClipBounds;
            PointF[] bottomRight = {
            new PointF(vpb.Size.Width, vpb.Size.Height)
            };
            e.Graphics.TransformPoints(
            CoordinateSpace.Device, CoordinateSpace.Page, bottomRight);
            float dpiX = e.Graphics.DpiX;
            float dpiY = e.Graphics.DpiY;
            return new Rectangle(0, 0, (int)(bottomRight[0].X * 100 / dpiX),
            (int)(bottomRight[0].Y * 100 / dpiY));
        }

        // Adjust MarginBounds rectangle when printing based
        // on the physical characteristics of the printer
        static Rectangle GetRealMarginBounds(
        PrintPageEventArgs e, bool preview)
        {
            if (preview) return e.MarginBounds;
            // Get printer's offsets
            float cx = e.PageSettings.HardMarginX;
            float cy = e.PageSettings.HardMarginY;
            // Create the real margin bounds by scaling the offset
            // by the printer resolution and then rescaling it
            // back to 1/100 inch
            Rectangle marginBounds = e.MarginBounds;
            float dpiX = e.Graphics.DpiX;
            float dpiY = e.Graphics.DpiY;
            marginBounds.Offset((int)(-cx * 100 / dpiX), (int)(-cy * 100 / dpiY));
            return marginBounds;
        }

        private void CaptureForm()
        {
            
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height);
            DrawToBitmap(memoryImage, new Rectangle(0, 0, memoryImage.Width, memoryImage.Height));
            memoryImages.Add(memoryImage);
            
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CaptureForm();
            
            this.printPreviewDialog.Document = this.printDocument;
            this.printPreviewDialog.Document.DocumentName = "TimTacToe";
            
            this.printPreviewDialog.ShowDialog();
        }

        
        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameOptionsDialog gameOptionsDialog = new GameOptionsDialog();
            gameOptionsDialog.ApplySettingsEventHandler += OptionsDialog_AcceptProperites;
            gameOptionsDialog.Location = new Point(this.Width, this.Location.Y);
            gameOptionsDialog.Show();
        }
        private void printDocument_BeginPrint(object sender, PrintEventArgs e)
        {
            PageCounter = 0;
            // Print preview?
            preview = (e.PrintAction == PrintAction.PrintToPreview);
            printerfont = new Font("Lucida Console", 25);
        }

        //event handler for properties
        private void OptionsDialog_AcceptProperites(object sender, GameOptionsDialog.ApplySettingsEventArgs e)
        {
            if (e.backgroundColor.ToArgb() != Color.Transparent.ToArgb())
            {
                this.BackColor = e.backgroundColor;

            }

            if (e.lineColor.ToArgb() != Color.Transparent.ToArgb())
            {
                pen.Color = e.lineColor;
                ShowLineOnInvalidate();
            }

            if (e.image1 != null)
            {
                imagePlayer1 = e.image1;
                RefreshImages();

            }

            if (e.image2 != null)
            {
                imagePlayer2 = e.image2;
                RefreshImages();
            }

        }

        private void RefreshImages()
        {
            this.player1Box.BackgroundImage = imagePlayer1;
            this.player2Box.BackgroundImage = imagePlayer2;
            foreach (SquareButton s in squares)
            {
                if (s.ButtonText == "X")
                {
                    s.BackgroundImage = imagePlayer1;
                }
                if(s.ButtonText == "O")
                {
                    s.BackgroundImage = imagePlayer2;
                }
            }
        }

        private void printDocument_EndPrint(object sender, PrintEventArgs e)
        {
            // Reclaim font
            printerfont.Dispose();
            printerfont = null;
        }

        private void pageSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Let user select page settings
            this.pageSetupDialog.Document = this.printDocument;
            this.pageSetupDialog.ShowDialog();
        }
        private void TicTacToe_Load(object sender, EventArgs e)
        {
            player1Box.AllowDrop = true;
            player2Box.AllowDrop = true;

        }
        private void Player1Box_DragDrop(object sender, DragEventArgs e)
        {

            var data = e.Data.GetData(DataFormats.FileDrop);
            if (data != null)
            {
                   var fileNames = data as string[];
                if (fileNames.Length > 0)
                {
                    player1Box.BackgroundImage = Image.FromFile(fileNames[0]);
                    imagePlayer1 = (Bitmap)Image.FromFile(fileNames[0]);

                }
            }
        }

        private void Player2Box_DragDrop(object sender, DragEventArgs e)
        {

            var data = e.Data.GetData(DataFormats.FileDrop);
            if (data != null)
            {
                var fileNames = data as string[];
                if (fileNames.Length > 0)
                {
                    player2Box.BackgroundImage = Image.FromFile(fileNames[0]);
                    imagePlayer2 = (Bitmap)Image.FromFile(fileNames[0]);

                }
            }

        }

        private void Player1Box_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void Player2Box_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

        }

        /*
         * allows us to draw over controls
         * hack...I mean code taken from: 
         * https://stackoverflow.com/questions/282838/drawing-on-top-of-controls-inside-a-panel-c-winforms
         */
        private void DrawWininigLine(object sender, Graphics g)
        {
            Point p1 = WiningLineStartPosition();
            Point p2 = WiningLineEndPositon();
            if (sender is SquareButton)
            {
                SquareButton btn = (SquareButton)sender;
                {
                    p1.X -= btn.Left;
                    p1.Y -= btn.Top;
                    p2.X -= btn.Left;
                    p2.Y -= btn.Top;
                }

            }
            g.DrawLine(pen, p1, p2);
        }

        private void tableLayoutPanelTicTacToe_Paint(object sender, PaintEventArgs e)
        {
            if (isWinner)
            {
                DrawWininigLine(sender, e.Graphics);
            }
        }

        private void buttonNewRound_Click(object sender, EventArgs e)
        {
            NewGame();
            isWinner = false;
            ShowLineOnInvalidate();
            buttonNewRound.Visible = false;
        }

        private void TicTacToe_Resize(object sender, EventArgs e)
        {
            ShowLineOnInvalidate();
        }

        private void ShowLineOnInvalidate()
        {
            
            tableLayoutPanelTicTacToe.Invalidate();
            foreach (SquareButton square in squares)
            {
                square.Invalidate();
            }

        }

        private Point WiningLineStartPosition()
        {
            Point calcPoint;
            int x = 0, y = 0;

            //assings starting position for the line vertically
            if (isWinnerVertical1)
            {
                 x = A1squareButton.Right  / 2;
                 y = 0;
            }
            else if (isWinnerVertical2)
            {
                x = A2squareButton.Right - A2squareButton.Left / 2;
                y = 0;
            }
            else if (isWinnerVertical3)
            {
                x = A3squareButton.Right - ((A3squareButton.Right - A3squareButton.Left) / 2);
                y = 0;
            }

            //assign the sarting position of the line horizontally
            else if (isWinnerHorizontalA)
            {
                x = 0;
                y = A1squareButton.Bottom / 2;

            }
            else if (isWinnerHorizontalB)
            {
                x = 0;
                y = B1squareButton.Bottom - B1squareButton.Top/ 2;

            }
            else if (isWinnerHorizontalC)
            {
                x = 0;
                y = C1squareButton.Bottom - (C1squareButton.Bottom - C1squareButton.Top) / 2;
            }

            //assings ending position for the line diagonally
            else if (isWinnerDiagonalLeft)
            {
                x = y = 0;
            }
            else if (isWinnerDiagonalRight)
            {
                x = 0;
                y = tableLayoutPanelTicTacToe.Height;
            }


                calcPoint = new Point(x, y);

            return calcPoint;
        }

        private Point WiningLineEndPositon()
        {
            Point calcPoint;
            int x = 0, y = 0;

            //assings ending position for the line vertically
            if (isWinnerVertical1)
            {
                x = C1squareButton.Right  / 2;
                y = tableLayoutPanelTicTacToe.Bottom;
            }

            else if (isWinnerVertical2)
            {
                x = C2squareButton.Right - C2squareButton.Left / 2;
                y = tableLayoutPanelTicTacToe.Bottom;
            }

            else if (isWinnerVertical3)
            {
                x = C3squareButton.Right - ((C3squareButton.Right - C3squareButton.Left)/2);
                y = tableLayoutPanelTicTacToe.Bottom;
            }

            //assings ending position for the line horizontally
            else if (isWinnerHorizontalA)
            {
                x = tableLayoutPanelTicTacToe.Right;
                y = A3squareButton.Bottom / 2;
            }
            else if (isWinnerHorizontalB)
            {
                x = tableLayoutPanelTicTacToe.Right;
                y = B3squareButton.Bottom - B3squareButton.Top/ 2;
            }
            else if (isWinnerHorizontalC)
            {
                x = tableLayoutPanelTicTacToe.Right;
                y = C3squareButton.Bottom - (C3squareButton.Bottom - C3squareButton.Top) / 2;
            }

            //assings ending position for the line diagonally
            else if (isWinnerDiagonalLeft)
            {
                x = tableLayoutPanelTicTacToe.Width;
                y = tableLayoutPanelTicTacToe.Height;
            }
            else if (isWinnerDiagonalRight)
            {
                x = tableLayoutPanelTicTacToe.Width;
                y = 0;
            }

            calcPoint = new Point(x, y);

            return calcPoint;
        }
    }
}
