using System;

namespace _02._09._Family_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            double PricePerDay = double.Parse(Console.ReadLine());
            int additional = int.Parse(Console.ReadLine());

            if (days > 7)
            {
                PricePerDay = PricePerDay * 0.95;
            }
            else
                PricePerDay = PricePerDay * 1.00;

            double totalCost = PricePerDay * days + (budget * additional / 100);

            if (budget >= totalCost)
            {
                double difference = budget - totalCost;
                Console.WriteLine($"Ivanovi will be left with {difference:F2} leva after vacation.");
            }
            else
            {
                double difference = totalCost - budget;
                Console.WriteLine($"{difference:F2} leva needed.");
            }



        }
    }
}
