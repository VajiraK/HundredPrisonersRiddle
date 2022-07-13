using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HundredPrisonersRiddle
{
    public class Room : IRoom
    {
        IBox[] boxes = new Box[100];
        Random random = new Random(DateTime.Now.Millisecond);

        public Room()
        {
            ArrangeBoxes();
        }

        private void ArrangeBoxes()
        {
            for (int i = 0; i < 100; i++)
            {
                boxes[i] = new Box(i + 1, GetUniqueNumber());
            }
        }

        private int GetUniqueNumber()
        {
            bool notFound;
            int i;
            int insideNumber;

            do
            {
                insideNumber = random.Next(1, 101);

                if (insideNumber == 101)
                    throw new Exception();

                notFound = false;

                for (i = 0; i < 100; i++)
                {
                    if (boxes[i] != null)
                    {
                        if (boxes[i].Inside == insideNumber)
                            notFound = true;
                    }
                    else
                    {
                        break;
                    }
                }

            } while (notFound);

            return insideNumber;
        }

        public IBox GetaBox(int boxNumber)
        {
            for (int i = 0; i < 100; i++)
            {
                if (boxes[i].Outside == boxNumber)
                    return boxes[i];
            }

            return null;
        }

    }
}
