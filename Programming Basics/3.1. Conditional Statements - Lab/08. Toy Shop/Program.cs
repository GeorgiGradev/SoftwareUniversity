using System;

namespace _08._Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double travelPrice = double.Parse(Console.ReadLine());
            int puzzel = int.Parse(Console.ReadLine());
            int doll = int.Parse(Console.ReadLine());
            int bear = int.Parse(Console.ReadLine());
            int mignion = int.Parse(Console.ReadLine());
            int truck = int.Parse(Console.ReadLine());

            double numberToys = puzzel + doll + bear + mignion + truck;
            double soldItemPrice = puzzel * 2.6 + doll * 3 + bear * 4.10 + mignion * 8.2 + truck * 2;

            if (numberToys >= 50)
            {
                double profit = soldItemPrice * 0.75 * 0.9;

                if (profit >= travelPrice)
                {
                    Console.WriteLine($"Yes! {profit - travelPrice:F2} lv left.");
                }
                else if (profit < travelPrice)
                {
                    Console.WriteLine($"Not enough money! {travelPrice - profit:F2} lv needed.");
                }
            }
            else if (numberToys < 50)
            {
                double profit = soldItemPrice * 0.9;
                if (profit >= travelPrice)
                {
                    Console.WriteLine($"Yes! {profit - travelPrice:F2} lv left.");
                }
                else if (profit < travelPrice)
                {
                    Console.WriteLine($"Not enough money! {travelPrice - profit:F2} lv needed.");
                }

            }
        }
    }
}
