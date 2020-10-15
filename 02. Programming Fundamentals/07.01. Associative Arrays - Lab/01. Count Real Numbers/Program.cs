using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> input = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();

            SortedDictionary<double, int> output = new SortedDictionary<double, int>();

            foreach (var number in input)
            {
                if (!output.ContainsKey(number))
                {
                    output[number] = 0;
                }
                output[number]++;
            }
            foreach (var item in output)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}

