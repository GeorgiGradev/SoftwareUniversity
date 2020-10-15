using System;

namespace _06._Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double stunts = double.Parse(Console.ReadLine());
            double clothesPrice = double.Parse(Console.ReadLine());

            double decor = budget * 0.1;

            if (stunts > 150)
            {
                clothesPrice = clothesPrice - (clothesPrice * 0.1);
            }

            if (budget < stunts * clothesPrice + decor)
            {
                double needed = (stunts * clothesPrice + decor) - budget;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {needed:F2} leva more.");
            }
            else
            {
                double more = budget - (stunts * clothesPrice + decor);
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {more:F2} leva left.");
            }

        }
    }
}
