using System;

namespace _01._Sign_of_Integer_Numbers
{
    class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            NumberSign(input);
        }
        static void NumberSign(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {number} is zero.");
            }
        }
    }
}

