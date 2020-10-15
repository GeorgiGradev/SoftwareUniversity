using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Same_Values_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<double, int> dict = new Dictionary<double, int>();
            double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                if (!dict.ContainsKey(input[i]))
                {
                    dict.Add(input[i], 0);
                }
                dict[input[i]]++;
            }

            foreach (var (key, value) in dict)
            {
                Console.WriteLine($"{key} - {value} times");
            }

        }
    }
}
