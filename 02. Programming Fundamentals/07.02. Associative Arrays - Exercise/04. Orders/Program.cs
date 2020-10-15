using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, List<double>>();

            while (true)
            {
                string[] input = Console.ReadLine()
                    .Split()
                    .ToArray();
                string key = input[0];

                if (key == "buy")
                {
                    break;
                }

                double price = double.Parse(input[1]);
                int count = int.Parse(input[2]);

                if (!dict.ContainsKey(key))
                {
                    dict.Add(key, new List<double>() { price, count });
                }
                else
                {
                    dict[key][0] = price;
                    dict[key][1] += count;
                }
            }

            foreach (var product in dict)
            {
                Console.WriteLine($"{product.Key} -> {(product.Value[0] * product.Value[1]):f2}");
            }
        }
    }
}
