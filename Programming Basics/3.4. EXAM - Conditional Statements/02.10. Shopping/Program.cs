using System;

namespace _02._10._Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int videoCardsNumber = int.Parse(Console.ReadLine());
            int processorsNumber = int.Parse(Console.ReadLine());
            int ramNumber = int.Parse(Console.ReadLine());

            double videoCardsPrice = 250.0 * videoCardsNumber;
            double processorPrice = videoCardsPrice * 0.35 * processorsNumber;
            double ramPrice = videoCardsPrice * 0.10 * ramNumber;

            double total = videoCardsPrice + processorPrice + ramPrice;

            if (videoCardsNumber > processorsNumber)
            {
                total = total * 0.85;
            }
            else
            {
                total = total * 1.0;
            }

            if (budget >= total)
            {
                double difference = budget - total;
                Console.WriteLine($"You have {difference:F2} leva left!");
            }
            else
            {
                double difference = total - budget;
                Console.WriteLine($"Not enough money! You need {difference:F2} leva more!");
            }
        }
    }
}
