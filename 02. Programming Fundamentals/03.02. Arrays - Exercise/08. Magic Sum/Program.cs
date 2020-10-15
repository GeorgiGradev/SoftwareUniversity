using System;
using System.Linq;

namespace _08._Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < input.Length; i++)
            {
                for (int k = i + 1; k < input.Length; k++)
                {
                    if (input[i] + input[k] == number)
                    {
                        Console.WriteLine($"{input[i]} {input[k]}");
                    }
                }
            }
        }
    }
}
