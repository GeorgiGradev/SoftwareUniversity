using System;

namespace _01._Biscuits_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int bisciutsWorkerDay = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int competitorBiscuits = int.Parse(Console.ReadLine());
            double production = 0;

            for (int i = 1; i <= 30; i++)
            {
                if (i % 3 != 0)
                {
                    production += bisciutsWorkerDay * workers;
                }
                else if (i % 3 == 0)
                {
                    production += Math.Floor(bisciutsWorkerDay * workers * 0.75);
                }
            }
            double percentage = 0;
            Console.WriteLine($"You have produced {production} biscuits for the past month.");
            if (production > competitorBiscuits)
            {
                percentage = (production - competitorBiscuits) / competitorBiscuits * 100;
                Console.WriteLine($"You produce {percentage:f2} percent more biscuits.");
            }
            else
            {
                percentage = (competitorBiscuits - production) / competitorBiscuits * 100;
                Console.WriteLine($"You produce {percentage:f2} percent less biscuits.");
            }
        }
    }
}
