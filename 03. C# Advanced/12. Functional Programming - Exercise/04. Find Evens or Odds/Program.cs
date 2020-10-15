using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int a = input[0];
            int b = input[1];

            string command = Console.ReadLine();
            List<int> output = Result(input, a, b, command);
            Console.WriteLine(string.Join(" ", output));
        }

        static List<int> Result(int[] input, int a, int b, string command)
        {
            List<int> output = new List<int>();
            for (int i = a; i <= b; i++)
            {
                if (command == "odd" && i % 2 != 0)
                {
                    output.Add(i);
                }
                else if (command == "even" && i % 2 == 0)
                {
                    output.Add(i);
                }
            }
            return output;
        }
    }
}
