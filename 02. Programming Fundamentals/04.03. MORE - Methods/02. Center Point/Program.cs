using System;

namespace _02._Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());

            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            PrintsClosestToTheCenterPoints(x1, y1, x2, y2);
        }
        static void PrintsClosestToTheCenterPoints(double x1, double y1, double x2, double y2)
        {
            double result = Math.Abs(x1) + Math.Abs(y1);
            double result2 = Math.Abs(x2) + Math.Abs(y2);

            if (result < result2)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }
    }
}
