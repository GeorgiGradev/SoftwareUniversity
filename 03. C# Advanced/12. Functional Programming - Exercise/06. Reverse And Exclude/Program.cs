using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Reverse_And_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Reverse().Select(int.Parse).ToList();
            int number = int.Parse(Console.ReadLine());

            Func<List<int>, int, List<int>> action = Operation;

            Console.WriteLine(string.Join(" ", action(input, number)));
        }

        static List<int> Operation(List<int> input, int number)
        {
            List<int> output = new List<int>();
                for (int i = 0; i < input.Count; i++)
                {
                    if (input[i] % number != 0)
                    {
                    output.Add(input[i]);
                    }
                }
            return output;
        }
    }
}
