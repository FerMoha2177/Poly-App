using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Final_Project
{
    public partial class EmailApp : Form
    {
        List<Email> emails = new List<Email>();
        Email emailDoc;
        string fileNameWithFullPath;
        public EmailApp()
        {

            InitializeComponent();
            saveToolStripMenuItem.Enabled = false;
            saveToolStripButton.Enabled = false;

        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            MailMessage msg = new MailMessage();

            try
            {

                msg.From = new MailAddress(textBoxFrom.Text);
                msg.To.Add(new MailAddress(textBoxTo.Text));
                msg.Subject = textBoxSubject.Text;
                msg.Body = textBoxMessage.Text;
                client.UseDefaultCredentials = false;
                client.EnableSsl = true;
               ;

                //client.Credentials = new NetworkCredential("finalproj4226@gmail.com", "windows4226");
                client.Credentials = new NetworkCredential(textBoxFrom.Text,
                     Microsoft.VisualBasic.Interaction.InputBox("Please input your account password:", "Input Password", "windows4226"));

                if (!string.IsNullOrEmpty(textBoxTo.Text) || textBoxTo.Text.Contains('@'))
                {
                    client.Send(msg);
                    toolStripStatusLabelEmail.Text = "Sent!";
                    MessageBox.Show("Email Sent!");
                    textBoxSubject.Text = null;
                    textBoxTo.Text = null;
                    textBoxFrom.Text = null;
                    textBoxMessage.Text = null;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to send message: " + ex.Message);
                toolStripStatusLabelEmail.Text = "Email not sent...";
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBoxSubject.SelectedText != "")
            {
                textBoxSubject.Cut();
            }
            else if (textBoxTo.SelectedText != "")
            {
                textBoxTo.Cut();
            }
            else if (textBoxFrom.SelectedText != "")
            {
                textBoxFrom.Cut();
            }
            else if (textBoxMessage.SelectedText != "")
            {
                textBoxMessage.Cut();
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBoxSubject.SelectionLength > 0)
            {
                textBoxSubject.Copy();
            }
            else if (textBoxTo.SelectionLength > 0)
            {
                textBoxTo.Copy();
            }
            else if (textBoxFrom.SelectionLength > 0)
            {
                textBoxFrom.Copy();
            }
            else if (textBoxMessage.SelectionLength > 0)
            {
                textBoxMessage.Copy();
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBoxSubject.ContainsFocus)
            {
                textBoxSubject.Paste();
            }
            else if (textBoxTo.ContainsFocus)
            {
                textBoxTo.Paste();
            }
            else if (textBoxFrom.ContainsFocus)
            {
                textBoxFrom.Paste();
            }
            else if (textBoxMessage.ContainsFocus)
            {
                textBoxMessage.Paste();
            }
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            if (textBoxSubject.SelectedText != "")
            {
                textBoxSubject.Cut();
            }
            else if (textBoxTo.SelectedText != "")
            {
                textBoxTo.Cut();
            }
            else if (textBoxFrom.SelectedText != "")
            {
                textBoxFrom.Cut();
            }
            else if (textBoxMessage.SelectedText != "")
            {
                textBoxMessage.Cut();
            }
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            if (textBoxSubject.SelectionLength > 0)
            {
                textBoxSubject.Copy();
            }
            else if (textBoxTo.SelectionLength > 0)
            {
                textBoxTo.Copy();
            }
            else if (textBoxFrom.SelectionLength > 0)
            {
                textBoxFrom.Copy();
            }
            else if (textBoxMessage.SelectionLength > 0)
            {
                textBoxMessage.Copy();
            }
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            if (textBoxSubject.ContainsFocus)
            {
                textBoxSubject.Paste();
            }
            else if (textBoxTo.ContainsFocus)
            {
                textBoxTo.Paste();
            }
            else if (textBoxFrom.ContainsFocus)
            {
                textBoxFrom.Paste();
            }
            else if (textBoxMessage.ContainsFocus)
            {
                textBoxMessage.Paste();
            }
        }

        private void clearCurrentEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxSubject.Text = null;
            textBoxTo.Text = null;
            textBoxFrom.Text = null;
            textBoxMessage.Text = null;
            toolStripStatusLabelEmail.Text = "Ready!";
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmailAboutDialog about = new EmailAboutDialog();
            about.ShowDialog();
        }

        private void textBoxMessage_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxMessage.Text))
            {
                e.Cancel = true;
                //textBoxMessage.Focus();
                errorProviderMessage.SetError(textBoxMessage, "Your message cannot be empty!");
            }
            else
            {
                e.Cancel = false;
                errorProviderMessage.SetError(textBoxMessage, null);
                errorProviderMessage.Clear();
            }
        }

        private void textBoxSubject_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxSubject.Text))
            {
                e.Cancel = true;
                //textBoxSubject.Focus();
                errorProviderSubject.SetError(textBoxSubject, "Your email needs a subject!");
            }
            else
            {
                e.Cancel = false;
                errorProviderSubject.SetError(textBoxSubject, null);
                errorProviderSubject.Clear();
            }
        }

        private void textBoxFrom_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxFrom.Text))
            {
                e.Cancel = true;
                //textBoxFrom.Focus();
                errorProviderFrom.SetError(textBoxFrom, "Sender email required.");
            }
            else if (!textBoxFrom.Text.Contains('@'))
            {
                e.Cancel = true;
                //textBoxFrom.Focus();
                errorProviderFrom.SetError(textBoxFrom, "Invalid email (example@example.com)");
            }
            else
            {
                e.Cancel = false;
                errorProviderFrom.SetError(textBoxFrom, null);
                errorProviderFrom.Clear();
            }
        }

        private void textBoxTo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxTo.Text))
            {
                e.Cancel = true;
                // textBoxTo.Focus();
                errorProviderTo.SetError(textBoxTo, "Receiving email required.");
            }
            else if (!textBoxTo.Text.Contains('@'))
            {
                e.Cancel = true;
                // textBoxTo.Focus();
                errorProviderTo.SetError(textBoxTo, "Invalid email (example@example.com)");
            }
            else
            {
                e.Cancel = false;
                errorProviderTo.SetError(textBoxTo, null);
                errorProviderTo.Clear();
            }
        }

        private void LoadDraft(string path)
        {
            this.fileNameWithFullPath = path;

            if (File.Exists(path))
            {
                this.fileNameWithFullPath = path;

                BinaryFormatter openingFile = new BinaryFormatter();
                Stream stream;
                using (stream = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    //bmp = (Bitmap)openingFile.Deserialize(stream); //added this show the png processing dont think it works
                    emailDoc = (Email)openingFile.Deserialize(stream);
                    if (emailDoc != null)
                    {
                        this.textBoxTo.Text = emailDoc.SenderEmail;
                        this.textBoxFrom.Text = emailDoc.RecieverEmail;
                        this.textBoxSubject.Text = emailDoc.Subject;
                        this.textBoxMessage.Text = emailDoc.Message;
                    }
                }

            }
            saveToolStripMenuItem.Enabled = true;
            saveToolStripButton.Enabled = true;
        }
        private void SaveDraft(string path)
        {

            BinaryFormatter savingFile = new BinaryFormatter();
            Stream stream;
            if (!String.IsNullOrEmpty(saveFileDialog.FileName))
            {
                using (stream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    emailDoc = new Email(this.textBoxTo.Text, this.textBoxFrom.Text, this.textBoxSubject.Text, this.textBoxMessage.Text, 0, this.textBoxMessage.Font);
                    savingFile.Serialize(stream, emailDoc);
                }
            }
        }
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Draft Emails (.DE)|*.DE|All Files (*.*)|*.*| Text Files (.txt)|*.txt|HTML Files (.html)|*.html";
            openFileDialog.Title = "Load Draft";
            openFileDialog.FileName = "";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                LoadDraft(openFileDialog.FileName);
                    
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            saveFileDialog.Filter = "Draft Emails (.DE)|*.DE|Text Files (.txt)|*.txt|All Files (*.*)|*.*|HTML Files (.html)|*.html";
            saveFileDialog.Title = "Save As Draft";
            saveFileDialog.FileName = "Untitled";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                SaveDraft(saveFileDialog.FileName);
            }
        }

        private void saveOnlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = saveFileDialog.FileName;
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            SaveDraft(fileNameWithFullPath);
        }

        private void gridviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmailDataGrid em = new EmailDataGrid();
            em.Data = emails;
            em.ShowDialog();
        }

        private void buttonSaveDraft_Click(object sender, EventArgs e)
        {
            emailDoc = new Email(this.textBoxTo.Text, this.textBoxFrom.Text, this.textBoxSubject.Text, this.textBoxMessage.Text, 0, this.textBoxMessage.Font);
            emailDoc.PropertyChanged += email_PropertyChanged;

            emails.Add(emailDoc);
            //ClearTextBoxes();
            this.toolStripStatusLabelEmail.Text = "Draft Saved";
        }

        private void ClearTextBoxes()
        {
            this.textBoxTo.Text = "";
            this.textBoxFrom.Text = "";
            this.textBoxSubject.Text = "";
            this.textBoxMessage.Text = "";
        }
        
        private void email_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            switch(e.PropertyName)
            {
                case "SenderEmail":
                    this.textBoxFrom.Text = emailDoc.SenderEmail;
                    break;
                case "Priority":
                    this.labelPriorityNumber.Text = emailDoc.Priority.ToString();
                    break;
                case "RecieverEmail":
                    this.textBoxTo.Text = emailDoc.RecieverEmail;
                    break;
                case "Subject":
                    this.textBoxSubject.Text = emailDoc.Subject;
                    break;
                case "Message":
                    this.textBoxMessage.Text = emailDoc.Message;
                    break;
                case "Font":
                    this.textBoxMessage.Font = emailDoc.Font;
                    break;

            }
        }
    }
}
