using System;

namespace _07._Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            int minNumber = int.MaxValue;

            while (count < n)
            {
                int num = int.Parse(Console.ReadLine());
                count++;
                if (num < minNumber)
                {
                    minNumber = num;
                }
            }
            Console.WriteLine(minNumber);
        }
    }
}
