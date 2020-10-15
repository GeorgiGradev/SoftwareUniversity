using System;

namespace _01._Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <=23; i++)
            {
                for (int k = 0; k <= 59; k++)
                {
                    Console.WriteLine($"{i}:{k}");
                }
            }
        }
    }
}
