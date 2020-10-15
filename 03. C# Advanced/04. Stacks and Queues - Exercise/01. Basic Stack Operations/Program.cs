using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nsx = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Stack<int> stack = new Stack<int>();

            int numberToPush = nsx[0];
            int numberToPop = nsx[1];
            int elementToFind = nsx[2];

            for (int i = 0; i < numberToPush; i++)
            {
                if (input.Count() > i)
                {
                    stack.Push(input[i]);
                }
            }
            for (int i = 0; i < numberToPop; i++)
            {
                if (stack.Any())
                {
                    stack.Pop();
                }
            }

            if (stack.Count == 0)
            {
                Console.WriteLine("0");
            }
            else if (!stack.Contains(elementToFind))
            {
                Console.WriteLine(stack.Min());
            }
            else
            {
                Console.WriteLine(stack.Contains(elementToFind).ToString().ToLower());
            }
        }
    }
}
