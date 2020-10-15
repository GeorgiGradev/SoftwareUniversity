using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;

namespace _08._Balanced_Parenthesis // {[()]}
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>();

            foreach (var item in input)
            {
                if (stack.Any())
                {
                    char toCheck = stack.Peek();
                    if (toCheck == '{' && item == '}')
                    {
                        stack.Pop();
                        continue;
                    }
                    else if (toCheck == '[' && item == ']')
                    {
                        stack.Pop();
                        continue;
                    }
                    else if (toCheck == '(' && item == ')')
                    {
                        stack.Pop();
                        continue;
                    }
                }
                stack.Push(item);
            }
            Console.WriteLine(!stack.Any() ? "YES" : "NO");
        }
    }
}
