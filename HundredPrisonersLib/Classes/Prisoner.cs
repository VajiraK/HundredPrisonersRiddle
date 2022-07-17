using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HundredPrisonersRiddle
{
    internal class Prisoner : IPrisoner
    {
        public int PrisonerId { get; set; }
        public List<int> VisitedBoxes { get; set; }
        public bool FoundMyBox { set { } }

        public int BoxQuota {get; set;}

        public Prisoner(int prisonerId, int boxQuota)
        {
            BoxQuota = boxQuota;
            PrisonerId = prisonerId;
            VisitedBoxes = new List<int>();
            FoundMyBox = false;
        }

        public IBox FindYourBox(IRoom room)
        {
            int boxId = this.PrisonerId;

            do
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
                }
                else
                {//Found his box :)
                    box.InvokeBoxVisited();
                    FoundMyBox = true;
                    return box;
                }
            }while(VisitedBoxes.Count != this.BoxQuota);

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
