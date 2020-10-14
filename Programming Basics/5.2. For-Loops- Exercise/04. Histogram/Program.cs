using System;

namespace _04._Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            int count4 = 0;
            int count5 = 0;

            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number < 200)
                {
                    count1 += 1;
                }
                else if (number < 400)
                {
                    count2 += 1;
                }
                else if (number < 600)
                {
                    count3 += 1;
                }
                else if (number < 800)
                {
                    count4 += 1;
                }
                else
                {
                    count5 += 1;
                }
            }
            p1 = count1 / (n * 1.0) * 100;
            p2 = count2 / (n * 1.0) * 100;
            p3 = count3 / (n * 1.0) * 100;
            p4 = count4 / (n * 1.0) * 100;
            p5 = count5 / (n * 1.0) * 100;

            Console.WriteLine($"{p1:F2}%");
            Console.WriteLine($"{p2:F2}%");
            Console.WriteLine($"{p3:F2}%");
            Console.WriteLine($"{p4:F2}%");
            Console.WriteLine($"{p5:F2}%");

        }
    }
}
