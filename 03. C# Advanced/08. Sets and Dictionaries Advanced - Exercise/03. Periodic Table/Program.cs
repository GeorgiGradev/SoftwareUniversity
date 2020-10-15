using System;
using System.Collections.Generic;

namespace _03._Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SortedSet<string> set = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                for (int k = 0; k < input.Length; k++)
                {
                    set.Add(input[k]);
                }
            }
            Console.WriteLine(string.Join(" ", set));
        }
    }
}
