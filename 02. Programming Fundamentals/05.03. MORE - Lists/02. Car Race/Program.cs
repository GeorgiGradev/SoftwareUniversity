using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Car_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> input = Console.ReadLine()
                .Split()
                .Select(decimal.Parse)
                .ToList();

            decimal[] racer1 = new decimal[input.Count / 2];
            decimal[] racer2 = new decimal[input.Count / 2];
            decimal sum1 = 0;
            decimal sum2 = 0;

            for (int i = 0; i < input.Count / 2; i++)
            {
                racer1[i] = input[i];
                if (racer1[i] > 0)
                {
                    sum1 += racer1[i];
                }
                else if (racer1[i] == 0)
                {
                    sum1 *= 0.8M;
                }
                racer2[i] = input[input.Count - i - 1];
                if (racer2[i] > 0)
                {
                    sum2 += racer2[i];
                }
                else if (racer2[i] == 0)
                {
                    sum2 *= 0.8M;
                }
            }

            if (sum1 < sum2)
            {
                Console.WriteLine($"The winner is left with total time: {sum1}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {sum2}");
            }
        }
    }
}
