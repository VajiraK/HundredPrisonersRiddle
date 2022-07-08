using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing;

namespace HundredPrisonersGUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void frmMain_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            using (Pen selPen = new Pen(Color.Blue))
            {

                g.DrawRectangle(selPen, 10, 10, 50, 50);
            }
        }
    }
}
