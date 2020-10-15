using System;

namespace _08._Equal_Pairs
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int currentSum = 0;
            int previousSum = 0;

            int currentDiff = 0;
            int maxDiff = 0;

            for (int i = 1; i <= n; i++)
            {
                previousSum = currentSum;

                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());

                currentSum = num1 + num2;
                currentDiff = Math.Abs(currentSum - previousSum);

                if (currentDiff > maxDiff && i >= 2)
                {
                    maxDiff = currentDiff;
                }

            }
            if (maxDiff == 0)
            {
                Console.WriteLine($"Yes, value={currentSum}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={maxDiff}");
            }
        }

    }
}
