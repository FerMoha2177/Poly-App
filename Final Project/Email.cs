using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    [Serializable]
    public class Email : INotifyPropertyChanged
    {
        private string senderEmail;
        private string recieverEmail;
        private string subject;
        private string message;
        private int priority;
        private Font font;

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
      
        public Email(string senderEmail, string recieverEmail, string subject, string message)
        {
            this.senderEmail = senderEmail;
            this.recieverEmail = recieverEmail;
            this.subject = subject;
            this.message = message;
        }

        public Email(string senderEmail, string recieverEmail, string subject, string message, int priority, Font font)
        {
            this.senderEmail = senderEmail;
            this.recieverEmail = recieverEmail;
            this.subject = subject;
            this.message = message;
            this.priority = priority;
            this.font = font;
        }

        public string SenderEmail
        {
            get
            {
                return this.senderEmail;
            }
            set
            {
                if (value != this.senderEmail)
                {
                    this.senderEmail = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public string RecieverEmail
        {
            get
            {
                return this.recieverEmail;
            }
            set
            {
                if (value != this.recieverEmail)
                {
                    this.recieverEmail = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public string Subject
        {
            get
            {
                return this.subject;
            }
            set
            {
                if (value != this.subject)
                {
                    this.subject = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public string Message
        {
            get
            {
                return this.message;
            }
            set
            {
                if (value != this.message)
                {
                    this.message = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public int Priority
        {
            get
            {
                return this.priority;
            }
            set
            {
                if(value != this.priority)
                {
                    this.priority = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public Font Font
        {
            get
            {
                return this.font;
            }

            set
            {
                if (value != this.font)
                {
                    this.font = value;
                    NotifyPropertyChanged();
                }
            }
        }
    }
}
