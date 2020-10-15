using System;

namespace _08._Circle_Area_and_Perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());

            double circleArea = Math.PI * r * r;
            double circlePerimeter = 2 * r * Math.PI;
            
            Console.WriteLine($"{circleArea:F2}");
            Console.WriteLine($"{circlePerimeter:F2}");



        }
    }
}
