using HundredPrisonersLib.Classes;
using System;

namespace HundredPrisonersRiddle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int a = 0; a < 10000; a++)
            {
                var f = new Factory();
                IRiddle riddle = f.GetRiddle();
                int c = 0;

                for (int i = 0; i < 100; i++)
                {
                    riddle.Initialize(50);
                    bool ret = riddle.Run();

                    if (ret)
                        c++;
                }

                if(c > 1)
                   Console.WriteLine(c);
            }

            Console.WriteLine("done!");
            Console.ReadKey();
        }
    }
}
