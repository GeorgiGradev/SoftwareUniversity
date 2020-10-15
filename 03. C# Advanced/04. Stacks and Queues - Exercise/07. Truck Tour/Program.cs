using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal n = decimal.Parse(Console.ReadLine());

            decimal startPump = 0;
            decimal fuelLeft = 0;

            for (decimal i = 0; i < n; i++)
            {
                List<decimal> pair = Console.ReadLine()
                                            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                            .Select(decimal.Parse)
                                            .ToList();

                decimal liters = pair[0];
                decimal km = pair[1];

                fuelLeft += liters;

                if (fuelLeft >= km)
                {
                    fuelLeft -= km;
                }
                else
                {
                    startPump = i + 1;
                    fuelLeft = 0;
                }

            }

            Console.WriteLine($"{startPump}");
        }
    }
}
