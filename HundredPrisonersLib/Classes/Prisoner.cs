using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HundredPrisonersRiddle
{
    public class Pisoner : IPisoner
    {
        public int PrisonerId { get; set; }

        public Pisoner(int prisonerId)
        {
            PrisonerId = prisonerId;
        }

        public IBox FindYourBox(IRoom room, int allowedNoOfBoxes)
        {
            int boxId = this.PrisonerId;

            for (int i = 0; i < allowedNoOfBoxes; i++)
            {
                IBox box = room.GetaBox(boxId);

                if (box.Inside != this.PrisonerId)
                {//My no not in the box
                    box = room.GetaBox(box.Inside);
                    boxId = box.Outside;
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
