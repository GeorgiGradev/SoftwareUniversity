using System;

namespace _01._Convert_Meters_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            decimal convertToKm = num / 1000M;
            Console.WriteLine($"{convertToKm:f2}");
        }
    }
}
