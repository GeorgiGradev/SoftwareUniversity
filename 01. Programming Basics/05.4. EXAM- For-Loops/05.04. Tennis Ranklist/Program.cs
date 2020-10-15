using System;

namespace _05._04._Tennis_Ranklist
{
    class Program
    {
        static void Main(string[] args)
        {
            double tours = int.Parse(Console.ReadLine());
            double points = int.Parse(Console.ReadLine());
            double totalPoints = 0;
            double newPoints = 0;
            double count = 0;

            for (int i = 0; i < tours; i++)
            {
                string stage = Console.ReadLine();

                if (stage == "W")
                {
                    newPoints += 2000;
                    count++;
                }
                if (stage == "F")
                {
                    newPoints += 1200;
                }
                if (stage == "SF")
                {
                    newPoints += 720;
                }
            }
            totalPoints = newPoints + points;
            Console.WriteLine($"Final points: {totalPoints}");
            Console.WriteLine($"Average points: {Math.Floor(newPoints / tours)}");
            Console.WriteLine($"{count/tours*100:F2}%");
        }
    }
}
