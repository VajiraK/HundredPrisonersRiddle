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
        public List<int> VisitedBoxes { get; set; }
        public bool FoundMyBox { set { } }

        public Pisoner(int prisonerId)
        {
            PrisonerId = prisonerId;
            VisitedBoxes = new List<int>();
            FoundMyBox = false;
        }

        public IBox FindYourBox(IRoom room, int allowedNoOfBoxes)
        {
            int boxId = this.PrisonerId;

            for (int i = 0; i < allowedNoOfBoxes; i++)
            {
                var box = VistiteBox(room, boxId);

                if (box.Inside != this.PrisonerId)
                {//No not his bos :(
                    box = VistiteBox(room, box.Inside);

                    if (box.Inside == this.PrisonerId)
                    {//Found his box :)
                        box.InvokeBoxVisited();
                        FoundMyBox = true;
                        return box;
                    }

                    boxId = box.Inside;
                    i++;
                }
                else
                {//Found his box :)
                    box.InvokeBoxVisited();
                    FoundMyBox = true;
                    return box;
                }
            }

            return null;
        }

        private IBox VistiteBox(IRoom room, int boxId)
        {
            var box = room.GetaBox(boxId);
            VisitedBoxes.Add(box.Outside);
            return box;
        }
    }
}
