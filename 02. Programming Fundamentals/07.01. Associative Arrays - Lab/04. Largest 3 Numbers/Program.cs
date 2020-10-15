using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _04._Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .OrderByDescending(x => x)
                .ToList();

            int count = input.Count >= 3 
                ? 3 
                : input.Count;

            for (int i = 0; i < count; i++)
            {
                Console.Write($"{input[i]} ");
            }
        }
    }
}
