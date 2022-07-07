using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HundredPrisonersRiddle
{
    internal class Riddle
    {
        public bool Run(int allowedNoOfBoxes)
        {
            int i;
            Room room = new Room();
            Prison prison = new Prison();

            room.ArrangeBoxes();
            prison.FillPrisoners();

            for (i = 0; i < 100; i++)
            {
                Prisoner prisoner = prison.GetPrisoner(i + 1);
                Box box = prisoner.FindYourBox(room, allowedNoOfBoxes);

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
