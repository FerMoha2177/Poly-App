using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class EmailDataGrid : Form
    {
        public Object Data
        {
            get
            { return this.bindingSourceEmail.DataSource; }
            set
            { this.bindingSourceEmail.DataSource = value; }

        }

        BindingManagerBase BindingManager
        {
            get { return this.BindingContext[this.Data]; }
        }
        public EmailDataGrid()
        {
            InitializeComponent();

            this.textBoxPriority.DataBindings.Add("Text", bindingSourceEmail, "priority");
            this.labelFont.DataBindings.Add("Font", bindingSourceEmail, "font");

            dataGridViewEmails.DataSource = bindingSourceEmail;
            RefreshItems();
        }

        void RefreshItems()
        {
            int count = this.BindingManager.Count;
            int pos = this.BindingManager.Position + 1;

            this.labelCount.Text = count.ToString();
            this.labelPosition.Text = pos.ToString();

            this.buttonFirst.Enabled = (pos > 1);
            this.buttonPrev.Enabled = (pos > 1);
            this.buttonNext.Enabled = (pos < count);
            this.buttonLast.Enabled = (pos < count);
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            this.BindingManager.Position = 0;
            RefreshItems();
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            --this.BindingManager.Position;
            RefreshItems();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            ++this.BindingManager.Position;
            RefreshItems();
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            this.BindingManager.Position = this.BindingManager.Count - 1;
            RefreshItems();
        }
        private void buttonFont_Click(object sender, EventArgs e)
        {

            FontDialog fontDialog1 = new FontDialog();
            fontDialog1.Font = labelFont.Font;
            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                labelFont.Font = fontDialog1.Font;
                labelFont.Focus();
                dataGridViewEmails.Focus();
            }
        }


    }
}
