using System;

namespace _05._Average_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int total = 0;
            double averageNum = 0;


            for (int i = 0; i < n; i ++)
            {
                int num = int.Parse(Console.ReadLine());
                total += num;

            }
            averageNum = total * 1.0 / n;
            Console.WriteLine($"{averageNum:F2}");
        }
    }
}

