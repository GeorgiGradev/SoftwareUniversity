using System;

namespace _04._LOOPS_While
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double food = double.Parse(Console.ReadLine());
            double counterDays = 0;
            double dogFoodTotal = 0;
            double catFoodTotal = 0;
            double totalEatenFood = 0;
            double biscuits = 0;

            for (int i = 0; i < days; i++)
            {
                double dogFood = double.Parse(Console.ReadLine());
                double catFood = double.Parse(Console.ReadLine());
                counterDays++;
                dogFoodTotal += dogFood;
                catFoodTotal += catFood;
                

                if (counterDays % 3 == 0)
                {
                    biscuits += ((dogFood + catFood) * 0.10);
                }
            }
            totalEatenFood = dogFoodTotal + catFoodTotal;
            Console.WriteLine($"Total eaten biscuits: {Math.Round(biscuits)}gr.");
            Console.WriteLine($"{((totalEatenFood / food ) * 100):f2}% of the food has been eaten.");
            Console.WriteLine($"{((dogFoodTotal / totalEatenFood) * 100):f2}% eaten from the dog.");
            Console.WriteLine($"{((catFoodTotal / totalEatenFood) * 100):f2}% eaten from the cat.");
        }
    }
}
