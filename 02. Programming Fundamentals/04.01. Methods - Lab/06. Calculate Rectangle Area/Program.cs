using System;

namespace _06._Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double height = double.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());

            Console.WriteLine(Area(height, length));
        }

        static double Area(double height, double length)
        {
            double result = height * length;


            return result;
        }
    }
}
