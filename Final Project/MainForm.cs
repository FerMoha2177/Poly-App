using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment3_Library;

namespace Final_Project
{
    public partial class MainForm : baseMainForm
    {
        /************************CUSTOM/HELPER METHODS************************/
        /// <summary>
        /// used for multi SDI. This returns a new MainForm after a multiSDI object is created. 
        /// </summary>
        /// <returns></returns>
        public static MainForm CreateTopLevelWindow()
        {
            MainForm newForm = new MainForm();
            newForm.Show();
            newForm.Activate();
            return newForm;
        }

        /// <summary>
        /// Checks whether the current there are more forms open. 
        /// Returns True if there is just 1 form open. False otherwise.
        /// </summary>
        /// <returns></returns>
        private bool IsLastForm()
        {
            int count = 0;
            foreach (Form form in Application.OpenForms)
            {
                count++;
            }

            return count == 1;
        }

        /************************MAIN FORM STARTS HERE************************/

        public MainForm()
        {

            InitializeComponent();
            

            MultiSDIApp.Application.AddTopLevelForm(this);
            menuStripBase.Enabled = false;

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm.CreateTopLevelWindow();

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsLastForm())
            {
                const string title = "Application Closing";
                const string message =
                      "Are you sure that you want to close the form?";

                //show messageBox with message
                var result = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // If the no button is pressed, cancel the closure of the form
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void buttonLaunchTicTacToe_Click(object sender, EventArgs e)
        {
            TicTacToe app1 = new TicTacToe();
            app1.Show();
        }

        private void oathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OathDialog oathDialog = new OathDialog();
            oathDialog.Show();
            //oathDialog.Owner = this;

            //if (!IsFormOpen(oathDialog))
            //{
            //    oathDialog.Show();
            //}
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutDialog aboutDialog = new AboutDialog();
            aboutDialog.Show();
            //aboutDialog.Owner = this;

            //if (!IsFormOpen(aboutDialog))
            //{
            //    aboutDialog.Show();
            //}
        }
        private void Fibonacci_Click(object sender, EventArgs e)
        {
            FibonacciCalculator fibonacciCalculatorForm = new FibonacciCalculator();
            fibonacciCalculatorForm.ShowDialog();
        }

        private void buttonEmail_Click(object sender, EventArgs e)
        {
            EmailApp emailForm = new EmailApp();
            emailForm.ShowDialog();
        }
    }
}
