using System;

namespace _10._Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum1 = 0;
            int sum2 = 0;

            for (int i = 0; i < n; i++ )
            {
                int input = int.Parse(Console.ReadLine());

                if (i % 2 != 0)
                {
                    sum1 += input;
                }
                else
                {
                    sum2 += input;
                }
            }

            if (sum1 == sum2)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sum1}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(sum1 - sum2)}");
            }
        }
    }
}
