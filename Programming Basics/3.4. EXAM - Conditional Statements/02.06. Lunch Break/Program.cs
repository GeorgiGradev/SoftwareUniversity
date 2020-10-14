using System;

namespace _02._06._Lunch_Break
{
    class Program
    {
        static void Main(string[] args)
        {
            string seriesName = Console.ReadLine();
            int seriesLenght = int.Parse(Console.ReadLine());
            int breakLenght = int.Parse(Console.ReadLine());

            double lunchLenght = 1.0 / 8 * breakLenght;
            double restLenght = 1.0 / 4 * breakLenght;
            double timeLeft = breakLenght - lunchLenght - restLenght;

            if (timeLeft >= seriesLenght)
            {
                double difference = timeLeft - seriesLenght;
                Console.WriteLine($"You have enough time to watch {seriesName} " +
                    $"and left with {Math.Ceiling(difference)} minutes free time.");
            }
            else
            {
                double difference = seriesLenght - timeLeft;
                Console.WriteLine($"You don't have enough time to watch {seriesName}, " +
                    $"you need {Math.Ceiling(difference)} more minutes.");
            }
        }
    }
}
