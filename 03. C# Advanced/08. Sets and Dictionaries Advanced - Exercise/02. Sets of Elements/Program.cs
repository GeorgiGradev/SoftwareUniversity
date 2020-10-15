using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();
            double n1 = input[0];
            double n2 = input[1];
            HashSet<double> set1 = new HashSet<double>();
            HashSet<double> set2 = new HashSet<double>();
            HashSet<double> set3 = new HashSet<double>();

            for (int i = 0; i < n1; i++)
            {
                set1.Add(double.Parse(Console.ReadLine()));
            }
            for (int i = 0; i < n2; i++)
            {
                set2.Add(double.Parse(Console.ReadLine()));
            }

            foreach (var item in set1)
            {
                if (set2.Contains(item))
                {
                    set3.Add(item);
                }
            }
            Console.WriteLine(string.Join(" ", set3));
        }
    }
}
