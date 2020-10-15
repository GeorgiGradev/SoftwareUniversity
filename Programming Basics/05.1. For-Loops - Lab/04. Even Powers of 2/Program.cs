using System;

namespace _02._Numbers_N1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // 3
            int num = 1;

            for (int i = 0; i <= n; i += 2)
            {
                Console.WriteLine(num);
                num = num * 2 * 2;

            }

        }
    }
}