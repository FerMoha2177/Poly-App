using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    class MultiSDIApp : WindowsFormsApplicationBase
    {
        private static MultiSDIApp app;

        internal static MultiSDIApp Application
        {
            get
            {
                if(app == null)
                {
                    app = new MultiSDIApp();
                }
                return app;
            }
        }

        public MultiSDIApp()
        {
            this.IsSingleInstance = true;
            this.ShutdownStyle = ShutdownMode.AfterAllFormsClose;
        }


        //private void CreateTopLevelWindow(ReadOnlyCollection<string> args)
        private MainForm CreateTopLevelWindow(ReadOnlyCollection<string> args)
        {
            String fileName = null;

            if(args.Count > 0)
            {
                fileName = args[0];
            }

            //need to do the long call to the static funtion cuz MainForm is a property for MultiSDIApp
            return Final_Project.MainForm.CreateTopLevelWindow(); 
        }
        protected override void OnCreateMainForm()
        {
            this.MainForm = CreateTopLevelWindow(this.CommandLineArgs);
        }

        protected override void OnStartupNextInstance(StartupNextInstanceEventArgs eventArgs)
        {
            CreateTopLevelWindow(eventArgs.CommandLine);
        }

        public void AddTopLevelForm(Form form)
        {
            form.FormClosed += Form_FormClosed;
            form.Activated += Form_Activated;
            if (this.OpenForms.Count == 1)
            {
                this.MainForm = form;
            }
        }

        void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form form = sender as Form;

            if(form == this.MainForm && this.OpenForms.Count > 0)
            {
                this.MainForm = (Form)this.OpenForms[0];
            }

            form.FormClosed -= Form_FormClosed;
            form.Activated -= Form_Activated;
        }

        void Form_Activated(Object sender, EventArgs e)
        {
            this.MainForm = (Form)sender;
        }


    }
}
