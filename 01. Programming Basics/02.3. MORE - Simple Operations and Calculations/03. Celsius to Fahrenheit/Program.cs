using System;

namespace _03._Celsius_to_Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double C = double.Parse(Console.ReadLine());

            double F = (C * 9 / 5) + 32;

            Console.WriteLine($"{F:F2}");

        }
    }
}
