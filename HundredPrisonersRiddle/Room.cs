﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HundredPrisonersRiddle
{
    internal class Room
    {
        public Box[] boxes = new Box[100];
        Random random = new Random(DateTime.Now.Millisecond);

        public void ArrangeBoxes()
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
                        if (boxes[i].inside == insideNumber)
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

        public Box GetaBox(int boxNumber)
        {
            for (int i = 0; i < 100; i++)
            {
                if(boxes[i].outside == boxNumber)
                    return boxes[i];    
            }

            return null;
        }

    }
}