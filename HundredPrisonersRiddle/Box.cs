using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HundredPrisonersRiddle
{
    internal class Box
    {
        public int inside;
        public int outside;
        private bool doPrint = false;

        public Box(int outside, int inside)
        {
            this.inside = inside;
            this.outside = outside;
        }

        public void Print()
        {
            if (doPrint)
                Console.WriteLine($"Box {this.outside} -> {this.inside}");
        }
    }
}
