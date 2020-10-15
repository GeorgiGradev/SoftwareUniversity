using System;
using System.Linq;

namespace _07._Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input1 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] input2 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            bool isTrue = true;
            int sum = input1.Sum();
            int position = 0;

            for (int i = 0; i < input1.Length; i++)
            { 
                if (input1[i] == input2[i])
                {
                    isTrue = true;
                }
                else
                {
                    isTrue = false;
                    position = i;
                    break;
                }
            }
            if (isTrue)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
            else
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {position} index");
            }
        }
    }
}
