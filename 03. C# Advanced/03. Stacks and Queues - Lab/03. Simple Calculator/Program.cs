using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().Reverse().ToArray();
            Stack<string> stack = new Stack<string>(input);
            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                while (stack.Count > 1)
                {
                    int number1 = int.Parse(stack.Pop());
                    string sign = stack.Pop();
                    int number2 = int.Parse(stack.Pop());
 
                    if (sign == "+")
                    {
                        sum = number1 + number2;
                    }
                    else if (sign == "-")
                    {
                        sum = number1 - number2;
                    }
                    stack.Push(sum.ToString());
                }
                

            }
            Console.WriteLine(stack.Pop());
        }
    }
}
