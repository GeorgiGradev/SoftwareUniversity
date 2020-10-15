using System;

namespace _06._Truck_Driver
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double kmMonth = double.Parse(Console.ReadLine());

            double kmTotal = 0;

            if (season == "Spring" || season == "Autumn")
            {
                if (kmMonth <= 5000)
                {
                    kmTotal = kmMonth * 0.75;
                }
                else if (kmMonth > 5000 && kmMonth <= 10000)
                {
                    kmTotal = kmMonth * 0.95;
                }
                else if (kmMonth > 10000 && kmMonth <= 20000)
                {
                    kmTotal = kmMonth * 1.45;
                }
            }
            else if (season == "Summer")
            {
                if (kmMonth <= 5000)
                {
                    kmTotal = kmMonth * 0.90;
                }
                else if (kmMonth > 5000 && kmMonth <= 10000)
                {
                    kmTotal = kmMonth * 1.10;
                }
                else if (kmMonth > 10000 && kmMonth <= 20000)
                {
                    kmTotal = kmMonth * 1.45;
                }
            }
            else
            {
                if (kmMonth <= 5000)
                {
                    kmTotal = kmMonth * 1.05;
                }
                else if (kmMonth > 5000 && kmMonth <= 10000)
                {
                    kmTotal = kmMonth * 1.25;
                }
                else if (kmMonth > 10000 && kmMonth <= 20000)
                {
                    kmTotal = kmMonth * 1.45;
                }
            }

            kmTotal = kmTotal * 0.90 * 4;

            Console.WriteLine($"{kmTotal:F2}");

        }
    }
}
