using System;

namespace _10._Renovation
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int percentEmptyArea = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            int totalArea = (height * width * 4);
            double workingArea = totalArea - (totalArea * 0.01 * percentEmptyArea);
            double liters = 0;

            while (command != "Tired!")
            {
                liters = int.Parse(command);
                workingArea -= liters;
                if (workingArea <= 0)
                {
                    liters = Math.Abs(workingArea);
                    break;
                }
                command = Console.ReadLine();
            }
            if (command == "Tired!")
            {
                Console.WriteLine($"{workingArea} quadratic m left.");
            }
            if (liters > 0 && command != "Tired!")
            {
                Console.WriteLine($"All walls are painted and you have {liters} l paint left!");
            }
            if (liters == 0)
            {
                Console.WriteLine("All walls are painted! Great job, Pesho!");
            }

        }
    }
}
