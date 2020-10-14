using System;

namespace _03._06._Movie_Destination
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string destination = Console.ReadLine();
            string season = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());

            double priceDay = 1;

            switch (destination)
            {
                case "Dubai":
                    {
                        if (season == "Winter")
                        {
                            priceDay = 45000 * 0.7;
                        }
                        else if (season == "Summer")
                        {
                            priceDay = 40000 * 0.7;
                        }
                        break;
                    }
                case "Sofia":
                    {
                        if (season == "Winter")
                        {
                            priceDay = 17000 * 1.25;
                        }
                        else if (season == "Summer")
                        {
                            priceDay = 12500 * 1.25;
                        }
                        break;
                    }
                case "London":
                    {
                        if (season == "Winter")
                        {
                            priceDay = 24000;
                        }
                        else if (season == "Summer")
                        {
                            priceDay = 20250;
                        }
                        break;
                    } 
            }
            double price = priceDay * days;
            double difference = Math.Abs(budget - price);

            if (budget >= price)
            {
                Console.WriteLine($"The budget for the movie is enough! We have {difference:F2} leva left!");
            }
            else
            {
                Console.WriteLine($"The director needs {difference:F2} leva more!"); 
            }
        }
    }
}
