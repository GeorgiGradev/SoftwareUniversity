using System;

namespace _06._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1111; i <= 9999; i++)
            {
                int temp = i;
                bool isSpecial = true;
                while (temp > 0)
                {
                    int digit = temp % 10;
                    if (digit == 0 || n % digit != 0)
                    {
                        isSpecial = false;
                        break;
                    }
                    temp = temp / 10;
                }
                if (isSpecial && temp == 0)
                Console.Write($"{i} ");
            }
        }
    }
}

