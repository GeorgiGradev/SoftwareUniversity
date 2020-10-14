using System;

namespace _05._06._Series
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            double newPrice = 0;
            double finalPrice = 0;

            for (int i = 0; i < n; i++)
            {
                string movie = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());



                if (movie == "Thrones")
                {
                    newPrice = price - (price * 0.50);
                }
                else if (movie == "Lucifer")
                {
                    newPrice = price - (price * 0.40);
                }
                else if (movie == "Protector")
                {
                    newPrice = price - (price * 0.30);
                }
                else if (movie == "TotalDrama")
                {
                    newPrice = price - (price * 0.20);
                }
                else if (movie == "Area")
                {
                    newPrice = price - (price * 0.10);
                }
                else
                {
                    newPrice = price;
                }
                finalPrice += newPrice;
            }

            double diff = Math.Abs(budget - finalPrice);

            if (budget >= finalPrice)
            {
                Console.WriteLine($"You bought all the series and left with {diff:f2} lv.");
            }
            else
            {
                Console.WriteLine($"You need {diff:f2} lv. more to buy the series!");
            }
        }
    }
}
