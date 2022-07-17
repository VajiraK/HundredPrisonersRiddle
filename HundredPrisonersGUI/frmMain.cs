using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing;
using HundredPrisonersRiddle;
using HundredPrisonersLib.Classes;

namespace HundredPrisonersGUI
{
    public partial class frmMain : Form
    {
        IRiddle riddle;

        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int top = 0;
            int left = 0;
            int step = 50;
            int boxCount = 0;

            var f = new Factory();
            IRiddle riddle = f.GetRiddle();
            riddle.Initialize(50);
            IRoom room = riddle.GetRoom();

            for (int a = 0; a < 10; a++)
            {
                for (int b = 0; b < 10; b++)
                {
                    boxCount++;
                    var box = room.GetaBox(boxCount);

                    var boxControl = new BoxControl()
                    {
                        Box = box,
                        Top = top,
                        Left = left
                    };

                    this.Controls.Add(boxControl);
                    left += step;
                }

                top += step;
                left = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            riddle.Run();
        }
    }
}
