using System;

namespace _06._Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            //При 100лв.или по-малко – някъде в България
            //   Лято – 30 % от бюджета
            //   Зима – 70 % от бюджета
            //При 1000лв.или по малко – някъде на Балканите
            //  Лято – 40 % от бюджета
            //  Зима – 80 % от бюджета
            //При повече от 1000лв. – някъде из Европа
            //  При пътуване из Европа, независимо от сезона ще похарчи 90 % от бюджета.

            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string region = "0";
            string place = "0";
            double moneySpent = 0;

            if (budget <= 100)
            {
                if (season == "summer")
                {
                    moneySpent = budget * 0.3;
                    region = "Bulgaria";
                    place = "Camp";
                }
                else if (season == "winter")
                {
                    moneySpent = budget * 0.7;
                    region = "Bulgaria";
                    place = "Hotel";
                }
            }
            else if (budget > 100 && budget <= 1000)
            {
                if (season == "summer")
                {
                    moneySpent = budget * 0.4;
                    region = "Balkans";
                    place = "Camp";
                }
                else if (season == "winter")
                {
                    moneySpent = budget * 0.8;
                    region = "Balkans";
                    place = "Hotel";
                }
            }
            else if (budget > 1000)
            {
                if (season == "summer" || season == "winter")
                {
                    moneySpent = budget * 0.9;
                    region = "Europe";
                    place = "Hotel";
                }
            }


            Console.WriteLine($"Somewhere in {region}");
            Console.WriteLine($"{place} - {moneySpent:F2}");



        }
    }
}
