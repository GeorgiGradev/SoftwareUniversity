using System;

namespace _06._Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int foodLeft = int.Parse(Console.ReadLine());
            double dogFood = double.Parse(Console.ReadLine());
            double catFood = double.Parse(Console.ReadLine());
            double turttleFood = double.Parse(Console.ReadLine());

            double totalFoodNeeded = (dogFood + catFood + (turttleFood / 1000)) * days;

            if (foodLeft >= totalFoodNeeded)
            {
                double leftover = foodLeft - totalFoodNeeded;
                Console.WriteLine($"{Math.Floor(leftover)} kilos of food left.");
            }
            else
            {
                double missing = totalFoodNeeded - foodLeft;
                Console.WriteLine($"{Math.Ceiling(missing)} more kilos of food are needed.");
            }

        }
    }
}
