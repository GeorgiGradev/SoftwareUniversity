using System;

namespace _06._Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            int maxNumber = int.MinValue;

            while (count < n)
            {
                int num = int.Parse(Console.ReadLine());
                count++;
                if (num > maxNumber)
                {
                    maxNumber = num;
                }
            }
            Console.WriteLine(maxNumber);
        }
    }
}
