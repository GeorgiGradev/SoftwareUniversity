using System;
using System.Linq;
namespace _07._01._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
            int bestCount = 0;
            int bestIndex = 0;
            string result = string.Empty;

            for (int i = 0; i < arr.Length-1; i++)
            {
                int currCount = 1;
                for (int k = i + 1; k < arr.Length; k++)
                {
                    if (arr[i] == arr[k])
                    {
                        currCount++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (currCount > bestCount)
                {
                    bestCount = currCount;
                    bestIndex = i;
                }
            }
            for (int i = 0; i < bestCount; i++)
            {
                result += arr[bestIndex] + " ";
            }
            Console.WriteLine(result);
        }
    }
}
