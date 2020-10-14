using System;

namespace _02._12._Summer_Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            double towelPrice = double.Parse(Console.ReadLine());
            int discountInPercent = int.Parse(Console.ReadLine());

            double umbrellaPrice = (2.0 / 3.0) * towelPrice;
            double shoesPrice = umbrellaPrice * 0.75;
            double bagPrice = (shoesPrice + towelPrice) * 1 / 3.00;

            double total = (umbrellaPrice + shoesPrice + bagPrice + towelPrice) * (1 - (discountInPercent / 100.00));

            if (budget >= total)
            {
                double difference = budget - total;
                Console.WriteLine($"Annie's sum is {total:F2} lv. She has {difference:F2} lv. left.");
            }
            else
            {
                double difference = total - budget;
                Console.WriteLine($"Annie's sum is {total:F2} lv. She needs {difference:F2} lv. more.");
            }
        }
    }
}
