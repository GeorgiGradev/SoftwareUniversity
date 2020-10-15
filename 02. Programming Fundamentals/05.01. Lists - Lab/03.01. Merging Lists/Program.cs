using System;
using System.Collections.Generic;
using System.Linq;
namespace _03._01._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input1 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> input2 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> resultNums = new List<int>();

            for (int i = 0; i < Math.Min(input1.Count, input2.Count); i++)
            {
                if (input1.Count > input2.Count)
                {
                    resultNums.AddRange(GetRemainingElements(input1, input2));
                }
                else if (input2.Count > input1.Count)
                {
                    resultNums.AddRange(GetRemainingElements(input2, input1));
                }
            }
            //TODO: Add numbers in resultNums

            Console.WriteLine(string.Join(" ", resultNums));
        }
        static List<int> GetRemainingElements(List<int> input1, List<int> input2)
        {
            List<int> nums = new List<int>();
            for (int i = input2.Count; i < input1.Count; i++)
            {
                nums.Add(input1[i]);
            }

            return nums;
        }
    }
}
