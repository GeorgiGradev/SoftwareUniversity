using System;

namespace _05._LOOPS_for
{
    class Program
    {
        static void Main(string[] args)
        {
            double capacity = double.Parse(Console.ReadLine());
            string suitcaseCommand = Console.ReadLine();

            int counter = 0;
            double totalVolume = 0;
            bool isSpace = true;

            while (suitcaseCommand != "End")
            {
                double suitcaseVolume = double.Parse(suitcaseCommand);
                counter++;

                if (counter % 3 == 0)
                {
                    suitcaseVolume *= 1.1;
                }

                totalVolume += suitcaseVolume;

                if (totalVolume > capacity)
                {
                    counter--;
                    Console.WriteLine("No more space!");
                    isSpace = false;
                    break;
                }
                suitcaseCommand = Console.ReadLine();
            }
            if (isSpace)
            {
                Console.WriteLine("Congratulations! All suitcases are loaded!");
            }
            Console.WriteLine($"Statistic: {counter} suitcases loaded.");
        }
    }
}
