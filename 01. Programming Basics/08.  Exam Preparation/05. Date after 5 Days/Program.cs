using System;

namespace _05._Date_after_5_Days
{
    class Program
    {
        static void Main(string[] args)
        {
            int d = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            d = d + 5;
            if (m == 2 && m == 02)
            {
                if (d > 28)
                {
                    d = d % 28;
                    m = m + 1;
                }
            }
            else if (m == 1 || m == 01 || m == 3 || m == 03 || m == 5 || m == 05 ||
                m == 7 || m == 07 || m == 8 || m == 08 || m == 10 || m == 12)
            {

                if (d > 31 && m ==12)
                {
                    d = d % 31;
                    m = 1;
                }
                if (d > 31)
                {
                    d = d % 31;
                    m = m + 1;
                }

            }
            else
            {
                if (d > 30)
                {
                    d = d % 30;
                    m = m + 1;
                }
            }
            Console.WriteLine($"{d}.{m:d2}");
        }
    }
}
