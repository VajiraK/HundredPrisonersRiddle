using HundredPrisonersRiddle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HundredPrisonersGUI
{
    public partial class BoxControl : UserControl
    {
        public IBox Box { get; set; }


        public BoxControl()
        {
            InitializeComponent();
        }

        private void BoxControl_Load(object sender, EventArgs e)
        {
            Box.BoxVisited += this.BoxVisited;
            this.lblInside.Text = Box.Inside.ToString();
            this.lblOutside.Text = Box.Outside.ToString();
        }

        private void BoxVisited()
        {
            this.BackColor = Color.LightGray;
        }

        private void BoxControl_Paint(object sender, PaintEventArgs e)
        {
            Rectangle r = new Rectangle(0,0,this.Size.Width-1, this.Height-1);

            Graphics g = e.Graphics;
            g.DrawRectangle(new Pen(Color.Black), r);
        }

        //public bool Visited 
        //{
        //    set {
        //        if (value)
        //        {
        //            this.BackColor = Color.LightGray;
        //        }
        //        else
        //        {
        //            this.BackColor = SystemColors.Control;
        //        }
        //    }
        //}
    }
}
