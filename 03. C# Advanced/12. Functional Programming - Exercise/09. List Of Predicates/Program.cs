using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._List_Of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> output = new List<int>();

            for (int i = 1; i <= number; i++)
            {
                bool isDivisable = true;
                for (int k = 0; k < input.Length; k++)
                {
                    if (i % input[k] != 0)
                    {
                        isDivisable = false;
                        break;
                    }

                }
                if (isDivisable)
                {
                    output.Add(i);
                }
            }
            Console.WriteLine(string.Join(" ", output));
        }
    }
}
