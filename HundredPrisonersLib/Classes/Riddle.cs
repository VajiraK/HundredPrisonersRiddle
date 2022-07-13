using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HundredPrisonersRiddle
{
    public class Riddle : IRiddle
    {
        IRoom room;
        IPrison prison;

        public IRoom GetRoom()
        {
            return room;
        }

        public void Initialize()
        {
            room = new Room();
            prison = new Prison();

            //room.ArrangeBoxes();
            prison.FillPrisoners();

        }

        public bool Run(int allowedNoOfBoxes)
        {
            int i;
            IBox box = null;

            for (i = 0; i < 100; i++)
            {
                IPisoner prisoner = prison.GetPrisoner(i + 1);
                box = prisoner.FindYourBox(room, allowedNoOfBoxes);

                if (box == null)
                    break;
            }

            return (i == 100) && (box != null);
        }
    }
}
