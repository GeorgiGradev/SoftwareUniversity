using System;
using System.Linq;

namespace _06._Even_and_Odd_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int even = 0;
            int odd = 0;
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    even += numbers[i];
                }
                else
                {
                    odd += numbers[i];
                }
            }
            Console.WriteLine($"{(even - odd)}");
        }
    }
}
