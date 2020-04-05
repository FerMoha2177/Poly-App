using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace Final_Project
{
   
    public partial class GameOptionsDialog : Form
    {
        public event EventHandler<ApplySettingsEventArgs> ApplySettingsEventHandler;

        public class ApplySettingsEventArgs : EventArgs
        {
            public Bitmap image1 { get; set; }
            public Bitmap image2 { get; set; }
            public Color backgroundColor { get; set; }
            public Color lineColor { get; set; }
        }

        private ApplySettingsEventArgs eventArgs = new ApplySettingsEventArgs();

        /************************CUSTOM/HELPER METHODS************************/
        /// <summary>
        /// Prompts a openfile dialog and returns the png image selected.
        /// </summary>
        /// <returns>bitmap or null </returns>
        private Bitmap changeImage()
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "Image files (*.png) |  *.png";

                if (dlg.ShowDialog() == DialogResult.OK)
                {                  
                    return new Bitmap(dlg.FileName);
                }
            }
            return null;
        }
        /*********************************************************************/

        public GameOptionsDialog()
        {
            InitializeComponent();
            eventArgs.image1 = null;
            eventArgs.image2 = null;
            eventArgs.backgroundColor = Color.Transparent;
            eventArgs.lineColor = Color.Transparent;

        }
        private void buttonApplySettings_Click(object sender, EventArgs e)
        {
            if (ApplySettingsEventHandler != null)
            {
                ApplySettingsEventHandler(this, eventArgs);
            }
        }

        private void buttonChangetImagePlayer1_Click(object sender, EventArgs e)
        {
            eventArgs.image1 = changeImage();
            this.groupBox1.BackgroundImage = eventArgs.image1;

        }

        private void buttonChangetImagePlayer2_Click(object sender, EventArgs e)
        {
            eventArgs.image2 = changeImage();
            this.groupBox2.BackgroundImage = eventArgs.image2;
        }

        private void buttonChangeBackgroundColor_Click(object sender, EventArgs e)
        {
            if (colorDialogTicTacToePreferences.ShowDialog() == DialogResult.OK)
            {
                this.panelBackgroundColorExample.BackColor = colorDialogTicTacToePreferences.Color;
                eventArgs.backgroundColor = this.panelBackgroundColorExample.BackColor;
            }
        }

        private void buttonChangeLineColor_Click(object sender, EventArgs e)
        {
            if (colorDialogTicTacToePreferences.ShowDialog() == DialogResult.OK)
            {
                this.panelLineColorExample.BackColor = colorDialogTicTacToePreferences.Color;
                eventArgs.lineColor = this.panelLineColorExample.BackColor;
            }
        }


    }
}
