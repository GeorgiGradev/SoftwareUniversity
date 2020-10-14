using System;

namespace _08._Number_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int min = int.MaxValue;
            int max = int.MinValue;


            for (int i = 1; i <= n; i++ )
            {
                int input = int.Parse(Console.ReadLine());
                if (input < min)
                {
                    min = input;
                }
                if (input > max)
                {
                    max = input;
                }
            }
            Console.WriteLine($"Max number: {max}");
            Console.WriteLine($"Min number: {min}");
        }
    }
}
