using System;

namespace _07._House_Painting
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double wallsArea = ((x * x * 2) - (1.2 * 2)) + ((y * x * 2) - (1.5 * 1.5 * 2));
            double paintWalls = wallsArea / 3.4;

            double roofArea = (x * h * 2) / 2 + (y * x * 2);
            double paintRoof = roofArea / 4.3;


            Console.WriteLine($"{paintWalls:F2}");
            Console.WriteLine($"{paintRoof:F2}");

        }
    }
}
