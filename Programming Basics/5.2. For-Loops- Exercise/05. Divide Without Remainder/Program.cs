using System;

namespace _05._Divide_Without_Remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;


            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    count1 += 1;
                }
                if (num % 3 == 0)
                {
                    count2 += 1;
                }
                if (num % 4 == 0)
                {
                    count3 += 1;
                }
            }
            p1 = (count1 * 1.0) / (n * 1.0) * 100;
            p2 = (count2 * 1.0) / (n * 1.0) * 100;
            p3 = (count3 * 1.0) / (n * 1.0) * 100;
            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
        }
    }
}
