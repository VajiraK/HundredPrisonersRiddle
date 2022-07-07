using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HundredPrisonersRiddle
{
    internal class Prison
    {
        public Prisoner[] Prisoners = new Prisoner[100];

        public void FillPrisoners()
        {
            for (int i = 0; i < 100; i++)
            {
                Prisoners[i] = new Prisoner(i + 1);
            }
        }

        public Prisoner GetPrisoner(int prisonerId)
        {
            return Prisoners[prisonerId - 1];
        }
    }
}
