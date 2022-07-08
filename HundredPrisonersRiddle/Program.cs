using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HundredPrisonersRiddle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                IRiddle riddle = new Riddle();
                int c = 0;

                for (int i = 0; i < 100; i++)
                {
                    riddle.Initialize();
                    bool ret = riddle.Run(50);

                    if (ret)
                        c++;
                }


                Console.WriteLine(c);

                Console.ReadKey();
            } while (true);

        }
    }
}
