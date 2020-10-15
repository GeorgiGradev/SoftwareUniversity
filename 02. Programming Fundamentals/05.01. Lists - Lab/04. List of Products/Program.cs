using System;
using System.Collections.Generic;
using System.Linq;
namespace _04._List_of_Products
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> input = new List<string>();

            for (int i = 0; i < n; i++)
            {
                input.Add(Console.ReadLine());
            }
            input.Sort();
            for (int i = 0; i < input.Count; i++)
            {
                Console.WriteLine($"{i+1}.{input[i]}");
            }
        }
    }
}
