using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace _02._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            Stack<int> stack = new Stack<int>(numbers);
            
            while (true)
            {
                string[] input = Console.ReadLine()
                    .Split()
                    .ToArray();

                if (input[0].ToLower() == "add")
                {
                    int number1 = int.Parse(input[1]);
                    int number2 = int.Parse(input[2]);
                    stack.Push(number1);
                    stack.Push(number2);

                }
                else if (input[0].ToLower() == "remove")
                {
                    int number = int.Parse(input[1]);
                    if (number <= stack.Count)
                    {
                        for (int i = 0; i < number; i++)
                        {
                            if (stack.Any())
                            {
                                stack.Pop();
                            }
                        }
                    }

                }
                else if (input[0].ToLower() == "end")
                {
                    break;
                }
            }
            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}
