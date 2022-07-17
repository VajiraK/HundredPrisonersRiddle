using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HundredPrisonersRiddle
{
    internal class Prison : IPrison
    {
        public IPrisoner[] Prisoners = new IPrisoner[100];

        public void FillPrisoners(int allowedNoOfBoxes)
        {
            for (int i = 0; i < 100; i++)
            {
                Prisoners[i] = new Prisoner(i + 1, allowedNoOfBoxes);
            }
        }

        public IPrisoner GetPrisoner(int prisonerId)
        {
            return Prisoners[prisonerId - 1];
        }
    }
}
