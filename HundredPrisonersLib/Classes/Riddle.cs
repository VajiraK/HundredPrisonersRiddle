using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HundredPrisonersRiddle
{
    public class Riddle : IRiddle
    {
        public bool Run(int allowedNoOfBoxes)
        {
            int i;
            IRoom room = new Room();
            IPrison prison = new Prison();

            room.ArrangeBoxes();
            prison.FillPrisoners();

            for (i = 0; i < 100; i++)
            {
                IPisoner prisoner = prison.GetPrisoner(i + 1);
                IBox box = prisoner.FindYourBox(room, allowedNoOfBoxes);

                if (box != null)
                {
                    box.Print();
                }
                else
                {
                    break;
                }
            }

            return i == 100;
        }
    }
}
