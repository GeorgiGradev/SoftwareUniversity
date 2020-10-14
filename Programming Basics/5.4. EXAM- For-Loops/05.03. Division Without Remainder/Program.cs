using System;

namespace _05._03._Division_Without_Remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double num = 0;
            double countP1 = 0;
            double countP2 = 0;
            double countP3 = 0;
            


            for (int i = 0; i < n; i++)
            {
                num = double.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    countP1++;
                }
                if (num % 3 == 0)
                {
                    countP2++;
                }
                if (num % 4 == 0)
                {
                    countP3++;
                }
            }
            double P1 = countP1 / n * 100;
            double P2 = countP2 / n * 100;
            double P3 = countP3 / n * 100;

            Console.WriteLine($"{P1:F2}%");
            Console.WriteLine($"{P2:F2}%");
            Console.WriteLine($"{P3:F2}%");

        }
    }
}
