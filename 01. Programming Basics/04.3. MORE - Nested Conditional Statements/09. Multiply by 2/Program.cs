using System;

namespace _09._Multiply_by_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());

            while (true)
            {
                if (num < 0)
                {
                    Console.WriteLine($"Negative number!");
                    break;
                }
                else if (num >= 0)
                {
                    double result = num * 2;
                    Console.WriteLine($"Result: {result:F2}");
                    num = double.Parse(Console.ReadLine());
                }
            }
        }
    }
}
