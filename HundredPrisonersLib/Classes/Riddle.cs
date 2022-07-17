using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HundredPrisonersRiddle
{
    internal class Riddle : IRiddle
    {
        IRoom room;
        IPrison prison;

        public IRoom GetRoom()
        {
            return room;
        }

        public void Initialize(int allowedNoOfBoxes)
        {
            room = new Room();
            prison = new Prison();
            prison.FillPrisoners(allowedNoOfBoxes);
        }

        public bool Run()
        {
            int i;
            IBox box = null;

            for (i = 0; i < 100; i++)
            {
                IPrisoner prisoner = prison.GetPrisoner(i + 1);
                box = prisoner.FindYourBox(room);

                if (box == null)
                    break;
            }

            return (i == 100) && (box != null);
        }
    }
}
