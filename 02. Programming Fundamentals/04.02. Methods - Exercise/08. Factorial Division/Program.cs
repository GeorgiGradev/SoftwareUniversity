using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = Math.Abs(int.Parse(Console.ReadLine()));
            int num2 = Math.Abs(int.Parse(Console.ReadLine()));
            decimal result = Factorial(num1, num2);
            Console.WriteLine($"{result:f2}");
        }

        static decimal Factorial(int num1, int num2)
        {
            decimal result1 = 1;
            decimal result2 = 1;
            for (int i = 2; i <= num1; i++)
            {
                result1 *= i;
            }
            for (int i = 2; i <= num2; i++)
            {
                result2 *= i;
            }
            decimal total = result1 / result2;
            return total;
        }
    }
}
