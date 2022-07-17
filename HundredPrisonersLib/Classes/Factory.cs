using HundredPrisonersRiddle;
using HundredPrisonersLib.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HundredPrisonersLib.Classes
{
    public class Factory
    {
        public IBox GetBox(int outside, int inside)
        {
            return new Box(outside, inside);
        }

        public IRoom GetRoom()
        {
            return new Room();
        }

        public IPrisoner GetPrisoner(int prisonerId, int boxQuota)
        {
            return new Prisoner(prisonerId, boxQuota);
        }

        public IRiddle GetRiddle()
        {
            return new Riddle();
        }
    }
}
