using System;
using System.Collections.Generic;
using System.Linq;
namespace _02._Gauss__Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < numbers.Count / 2; i++)
            {
                numbers[i] += numbers[numbers.Count - 1];
                numbers.RemoveAt(numbers.Count - 1);
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
