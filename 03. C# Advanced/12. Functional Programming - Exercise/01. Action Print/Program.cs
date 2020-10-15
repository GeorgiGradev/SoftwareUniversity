using System;
using System.Data;

namespace _01._Action_Print
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Action<string> action = Print;
            for (int i = 0; i < input.Length; i++)
            {
                action(input[i]);
            }
        }

       static void Print(string name)
        {
            Console.WriteLine(name);
        }
    }
}
