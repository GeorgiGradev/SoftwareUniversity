using System;
using System.Text;

namespace _04._Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var strB = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                strB.Append((char)(input[i] + 3));
            }

            Console.WriteLine(strB);
        }
    }
}
