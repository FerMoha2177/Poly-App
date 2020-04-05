using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Final_Project
{
    public partial class FibonacciCalculator : Form
    {
        public FibonacciCalculator()
        {
            InitializeComponent();
        }

        private void ShowProgress(int n, int i)
        {
            this.fibonacciCalculationToolStripProgressBar.Maximum = n;
            this.fibonacciCalculationToolStripProgressBar.Value = i;

            if (n == i)
            {
                this.fibonacciCalculationToolStripStatusLabel.Text = "Ready";
                this.fibonacciCalculationToolStripProgressBar.Visible = false;
            }

            this.Refresh();
        }

        private void CalculateNthFibonacciNumber(int n)
        {
            if (n <= 0)
            {
                this.fibonacciAnswerTextBox.Text = "Invalid input";
                return;
            }

            Int64 previous = 1;
            Int64 current = 1;
            int numbersCalculatedSinceLastProgressShown = 2;

            //We start at 3 because the first and the second Fibonacci numbers are already known
            for (int i = 3; i <= n; i++)
            {
                Int64 temp = current;
                current = current + previous;
                previous = temp;
                numbersCalculatedSinceLastProgressShown++;

                if (numbersCalculatedSinceLastProgressShown == 10 || i == n)
                {
                    ShowProgress(n, i);
                    numbersCalculatedSinceLastProgressShown = 0;
                }
            }

            ShowProgress(n, n);
            this.fibonacciAnswerTextBox.Text = current.ToString();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            this.fibonacciCalculationToolStripProgressBar.Visible = true;
            this.fibonacciCalculationToolStripStatusLabel.Text = "Calculating...";

            this.CalculateNthFibonacciNumber((int)this.fibonacciNValueNumericUpDown.Value);
        }
    }
}
