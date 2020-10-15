using System;
using System.Linq;
namespace _06._Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            bool isEqual = false;
            for (int i = 0; i < input.Length; i++)
            {
                int sumLeft = 0;
                int sumRight = 0;

                for (int k = 0; k < i; k++)
                {
                    sumLeft += input[k];
                }
                for (int k = i + 1; k < input.Length; k++)
                {
                    sumRight += input[k];
                }
                if (sumLeft == sumRight)
                {
                    Console.WriteLine(i);
                    isEqual = true;
                    break;
                }
            }
            if (isEqual == false && input.Length > 1)
            {
                Console.WriteLine("no");
            }
        }
    }
}
