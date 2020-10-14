using System;

namespace _03._Lucky_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int a = 1; a <=9; a++)
            {
                for (int b = 1; b <= 9; b++)
                {
                    for (int c = 1; c <= 9; c++)
                    {
                        for (int d = 1; d <= 9; d++)
                        {
                            if ((a + b == c + d) && (n % (a + b)) == 0)
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
