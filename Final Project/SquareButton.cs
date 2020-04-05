using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Final_Project
{
    class SquareButton : Control
    {
        private string buttonText;
        private Image backImage;

        public SquareButton()
        {
            buttonText = "";
            backImage = null;
            
        }

        //protected override void OnMouseDown(MouseEventArgs e)
        //{
        //    base.OnMouseDown(e);
        //    MessageBox.Show("Clicked");
        //}

        public string ButtonText { get => buttonText; set => buttonText = value; }
        public Image BackImage { get => backImage; set => backImage = value; }
    }
}
