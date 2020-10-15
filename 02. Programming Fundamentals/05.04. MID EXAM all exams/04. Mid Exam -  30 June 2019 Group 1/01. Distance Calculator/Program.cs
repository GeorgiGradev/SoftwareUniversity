using System;
using System.Diagnostics.Tracing;

namespace _01._Distance_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int stepsMade = int.Parse(Console.ReadLine());
            double stepLenght = double.Parse(Console.ReadLine()) / 100;
            double distance = double.Parse(Console.ReadLine());
            int counter = 0;
            double distanceTravelled = 0;
            double percentage = 0;

            while (stepsMade > 0)
            {
                counter++;
                if (counter % 5 != 0)
                {
                    distanceTravelled += stepLenght;
                }
                else if (counter % 5 == 0)
                {
                    distanceTravelled += (stepLenght * 0.70);
                }
                stepsMade--;
            }
            if (distance == 0)
            {
                Console.WriteLine($"You travelled 100.00% of the distance!");
            }
            else if (distance > 0)
            {
                percentage = (distanceTravelled / distance) * 100;
                if (percentage >= 100)
                {
                    Console.WriteLine($"You travelled 100.00% of the distance!");
                }
                else
                {
                    Console.WriteLine($"You travelled {percentage:f2}% of the distance!");
                }
            }

            
        }
    }
}
