using System;

namespace StringDisperser
{
    class StringDisperserTester
    {
        static void Main()
        {
            var stringDispersers = new StringDisperser[]
            {
                new StringDisperser("gamma", "beta", "gamma", "delta"),
                new StringDisperser("beta", "alpha", "gamma", "delta"),
                new StringDisperser("alpha", "gamma", "beta", "delta"),
            };

            Array.Sort(stringDispersers);

            foreach (var stringDisperser in stringDispersers)
            {
                Console.WriteLine(stringDisperser);
            }

            Console.WriteLine();

            Console.WriteLine(stringDispersers[0].Equals(stringDispersers[1]));
            Console.WriteLine(stringDispersers[0].Equals(stringDispersers[0]));
            Console.WriteLine();

            foreach (var stringDisperser in stringDispersers)
            {
                foreach (var ch in stringDisperser)
                {
                    Console.Write(ch + " ");
                }

                Console.WriteLine();
            }          
        }
    }
}
