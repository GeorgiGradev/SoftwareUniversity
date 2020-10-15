using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(input);
            int capacity = int.Parse(Console.ReadLine());
            int racks = 0;

            while (true)
            {
                int sum = 0;
                if (stack.Any())
                {
                    while (sum + stack.Peek() <= capacity && stack.Count > 0)
                    {
                        sum += stack.Pop();
                        if (stack.Count == 0)
                        {
                            racks++;
                            Console.WriteLine(racks);
                            return;
                        }
                    }
                    racks++;
                }
                else
                {
                    Console.WriteLine(racks);
                    break;
                }
            }
        }
    }
}
