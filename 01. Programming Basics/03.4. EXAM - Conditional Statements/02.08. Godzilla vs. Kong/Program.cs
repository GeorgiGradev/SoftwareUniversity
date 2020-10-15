using System;

namespace _02._08._Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int actors = int.Parse(Console.ReadLine());
            double clothesPrice = double.Parse(Console.ReadLine());

            if (actors > 150)
            {
                clothesPrice = clothesPrice * 0.90;
            }

            else
            {
                clothesPrice = clothesPrice * 1.0;
            }
                

            double totalClothesPrice = clothesPrice * actors;
            double costs = totalClothesPrice + (budget * 0.10);

            if (costs > budget)
            {
                double difference = costs - budget;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {difference:F2} leva more.");
            }
            else
            {
                double difference = budget - costs;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {difference:F2} leva left.");
            }
        }
    }
}
