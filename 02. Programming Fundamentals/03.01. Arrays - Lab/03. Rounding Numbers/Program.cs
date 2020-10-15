using System;
using System.Linq;
namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                double rounded = Math.Round(input[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{(decimal)input[i]} => {(decimal)rounded}");
            }
        }
    }
}
