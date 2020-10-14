using System;

namespace _02._03._Safari
{
    class Program
    {
        static void Main(string[] args)
        {
            //Цената на един литър гориво е 2.10 лв.
            //Цената за екскурзовод е 100лв.
            //за събота 10 %, а за неделя 20 % discount

            double budget = double.Parse(Console.ReadLine());
            double fuelLtrNeeded = double.Parse(Console.ReadLine());
            string day = (Console.ReadLine());

            double fuelPrice = 2.10 * fuelLtrNeeded;
            double guidePrice = 100;

            if (day == "Saturday")
            {
                double total = (fuelPrice + guidePrice) * 0.90;
                if (budget >= total)
                {
                    double leftover = budget - total;
                    Console.WriteLine($"Safari time! Money left: {leftover:F2} lv.");
                }
                else
                {
                    double missing = total - budget;
                    Console.WriteLine($"Not enough money! Money needed: {missing:F2} lv.");
                }
                   
            }
            else if (day == "Sunday")
            {
                double total = (fuelPrice + guidePrice) * 0.80;
                if (budget >= total)
                {
                    double leftover = budget - total;
                    Console.WriteLine($"Safari time! Money left: {leftover:F2} lv.");
                }
                else
                {
                    double missing = total - budget;
                    Console.WriteLine($"Not enough money! Money needed: {missing:F2} lv.");
                }
            }

        }
    }
}
