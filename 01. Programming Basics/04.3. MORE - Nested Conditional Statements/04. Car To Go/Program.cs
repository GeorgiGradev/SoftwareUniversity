using System;

namespace _04._Car_To_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string klas = "0";
            double carPrice = 0;
            string type = "0";

            if (budget <= 100)
            {
                klas = "Economy class";
                if (season == "Summer")
                {
                    carPrice = budget * 0.35;
                    type = "Cabrio";
                }
                else
                {
                    carPrice = budget * 0.65;
                    type = "Jeep";
                }
            }
            else if (budget > 100 && budget <= 500)
            {
                klas = "Compact class";
                if (season == "Summer")
                {
                    carPrice = budget * 0.45;
                    type = "Cabrio";
                }
                else
                {
                    carPrice = budget * 0.80;
                    type = "Jeep";
                }
            }
            else
            {
                klas = "Luxury class";
                carPrice = budget * 0.90;
                type = "Jeep";
            }

            Console.WriteLine($"{klas}");
            Console.WriteLine($"{type} - {carPrice:F2}");
        }
    }
}
