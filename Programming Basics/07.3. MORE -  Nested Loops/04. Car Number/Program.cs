using System;

namespace _04._Car_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int a = start; a <= end; a++)
            {
                for (int b = start; b <= end; b++)
                {
                    for (int c = start; c <= end; c++)
                    {
                        for (int d = start; d <= end; d++)
                        {
                            if (((a % 2 == 0 && d % 2 != 0) || (a % 2 != 0 && d % 2 == 0)) && a > d && ((b + c) % 2 == 0))
                            {
                                Console.Write($"{a}{b}{c}{d} ");
                            }

                        }

                    }
                }
            }
        }
    }
}

