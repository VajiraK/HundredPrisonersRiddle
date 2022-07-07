using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HundredPrisonersRiddle
{
    internal class Prisoner
    {
        public int PrisonerId { get; set; }

        public Prisoner(int prisonerId)
        {
            PrisonerId = prisonerId;
        }

        public Box FindYourBox(Room room, int allowedNoOfBoxes)
        {
            int boxId = this.PrisonerId;

            for (int i = 0; i < allowedNoOfBoxes; i++)
            {
                Box box = room.GetaBox(boxId);

                if (box.inside != this.PrisonerId)
                {//My no not in the box
                    box = room.GetaBox(box.inside);
                    boxId = box.outside;
                    i++;
                }
                else
                {
                    return box;
                }
            }

            return null;
        }
    }
}
