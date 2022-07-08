using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HundredPrisonersRiddle
{
    public class Box : IBox
    {
        private bool doPrint = true;

        public event Visited BoxVisited;

        public int Inside { get; set; }
        public int Outside { get; set; }

        public Box(int outside, int inside)
        {
            this.Inside = inside;
            this.Outside = outside;
        }

        public void Print()
        {
            if (doPrint)
                Console.WriteLine($"Box {this.Outside} -> {this.Inside}");
        }

        public void InvokeBoxVisited()
        {
            this.BoxVisited?.Invoke();
        }
    }
}
