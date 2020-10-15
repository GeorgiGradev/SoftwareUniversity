using System;
using System.Linq;
namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] input = new string[2];
            int counter = 0;

            string[] output1 = new string[n];
            string[] output2 = new string[n];

            for (int i = 0; i < n; i++)
            {
                counter++;
                input = Console.ReadLine()
                    .Split()
                    .ToArray();

                if (counter % 2 != 0)
                {
                    output1[i] = input[0];
                    output2[i] = input[1];
                }
                else if (counter % 2 == 0)
                {
                    output1[i] = input[1];
                    output2[i] = input[0];
                }
            }
            Console.WriteLine(string.Join(" ", output1));
            Console.WriteLine(string.Join(" ", output2));
        }
    }
}
