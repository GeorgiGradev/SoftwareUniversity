using System;
using System.Linq;

namespace _04._Tribonacci_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(TribonacciSequence(n));

        }

        static string TribonacciSequence(int n)
        {
            string result = string.Empty;

            if (n == 1)
            {
                result = "1";
                return result;
            }
            else if (n == 2)
            {
                result = "1 1";
                return result;
            }
            else if (n == 3)
            {
                result = "1 1 2";
                return result;
            }
            else
            {
                int[] output = new int[n];
                output[0] = 1;
                output[1] = 1;
                output[2] = 2;
                for (int i = 3; i < n; i++)
                {
                    output[i] = output[i-1] + output[i-2] + output[i-3];
                }
                result = string.Join(" ", output);
                return result;
            }
        }
    }
}
