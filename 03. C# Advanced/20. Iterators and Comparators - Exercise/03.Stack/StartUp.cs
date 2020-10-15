using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Stack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "END")
            {
                string[] elements = command.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Skip(1).ToArray();

                if (command.Contains("Push"))
                {
                    stack.Push(elements);
                }
                else if (command.Contains("Pop"))
                {
                    try
                    {
                        stack.Pop();
                    }
                    catch (InvalidOperationException ioe)
                    {
                        Console.WriteLine(ioe.Message);
                    }
                }
            }

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
    
}
