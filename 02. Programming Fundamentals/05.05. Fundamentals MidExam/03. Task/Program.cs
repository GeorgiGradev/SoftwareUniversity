using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _03._Task
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> output = new List<int>();
            List<int> result = new List<int>();

            int sum = input.Sum();
            double averageValue = sum / (double)input.Count;

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] > averageValue)
                {
                    output.Add(input[i]);
                }
            }

            output.Sort();
            output.Reverse();
            int count = 0;
            for (int i = 0; i < output.Count; i++)
            {
                count++;
                result.Add(output[i]);
                if (count == 5)
                {
                    break;
                }
            }
            if (result.Count == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine(string.Join(" ", result));
            }
        }
    }
}
