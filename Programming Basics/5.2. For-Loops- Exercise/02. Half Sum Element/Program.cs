using System;

namespace _02._Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int currNum = 0;
            int maxNumber = int.MinValue;
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                currNum = int.Parse(Console.ReadLine());
                sum += currNum;
                if (currNum > maxNumber)
                {
                    maxNumber = currNum;
                }
            }

            sum = sum - maxNumber;

            if (sum == maxNumber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {maxNumber}");
            }
            else
            {
                int diff = Math.Abs(sum - maxNumber);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}
