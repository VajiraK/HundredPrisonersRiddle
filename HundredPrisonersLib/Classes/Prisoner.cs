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
                var box = room.GetaBox(boxId);
                box.Print();

                if (box.Inside != this.PrisonerId)
                {//No not his bos :(
                    box = room.GetaBox(box.Inside);
                    box.Print();

                    if (box.Inside == this.PrisonerId)
                    {//Found his box :)
                        box.InvokeBoxVisited();
                        Console.WriteLine("FOUD");
                        return box;
                    }

                    boxId = box.Inside;
                    i++;
                }
                else
                {//Found his box :)
                    box.InvokeBoxVisited();
                    Console.WriteLine("FOUD");
                    return box;
                }
            }

            return null;
        }
    }
}
