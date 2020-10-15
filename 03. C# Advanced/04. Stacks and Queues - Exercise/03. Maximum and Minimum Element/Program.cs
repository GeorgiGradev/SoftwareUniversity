using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();

            for (int i = 1; i <= n; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (input.Length == 1)
                {
                    int action = input[0];
                    if (stack.Count > 0)
                    {
                        if (action == 2)
                        {
                            stack.Pop();
                        }
                        else if (action == 3)
                        {
                            Console.WriteLine(stack.Max());
                        }
                        else if (action == 4)
                        {
                            Console.WriteLine(stack.Min());
                        }
                    }
                }
                else
                {
                    int element = input[1];
                    stack.Push(element);
                }
            }
            if (stack.Count > 0)
            {

                Console.WriteLine(string.Join(", ", stack));

            }
        }
    }
}
