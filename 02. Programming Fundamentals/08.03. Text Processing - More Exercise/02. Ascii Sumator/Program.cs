using System;
using System.Text;

namespace _02._Ascii_Sumator
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol1 = char.Parse(Console.ReadLine());
            char symbol2 = char.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] > Math.Min(symbol1, symbol2) && input[i] < Math.Max(symbol1, symbol2))
                {
                    sum += input[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
