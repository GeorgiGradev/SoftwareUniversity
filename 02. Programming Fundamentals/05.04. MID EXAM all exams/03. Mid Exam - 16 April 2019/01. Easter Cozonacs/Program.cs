using System;

namespace _01._Easter_Cozonacs
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double flour1kg = double.Parse(Console.ReadLine());
            double eggPack = flour1kg * 0.75;
            double milk1liter = flour1kg * 1.25;
            int counter = 0;
            double csnPrice = eggPack + (milk1liter / 4) + flour1kg;
            double eggs = 0;

            while (budget - csnPrice >= 0)
            {
                counter++;
                budget -= csnPrice;
                eggs += 3;
                if (counter % 3 == 0)
                {
                    eggs -= counter - 2;
                }
            }
            Console.WriteLine($"You made {counter} cozonacs! Now you have {eggs} eggs and {budget:f2}BGN left.");
        }
    }
}
