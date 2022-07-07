using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HundredPrisonersRiddle
{
    public class Prison : IPrison
    {
        public IPisoner[] Prisoners = new IPisoner[100];

        public void FillPrisoners()
        {
            for (int i = 0; i < 100; i++)
            {
                Prisoners[i] = new Pisoner(i + 1);
            }
        }

        public IPisoner GetPrisoner(int prisonerId)
        {
            return Prisoners[prisonerId - 1];
        }
    }
}
