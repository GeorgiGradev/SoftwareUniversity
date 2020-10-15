using System;

namespace _03._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol1 = char.Parse(Console.ReadLine());
            char symbol2 = char.Parse(Console.ReadLine());

            int num1 = (int)symbol1;
            int num2 = (int)symbol2;
            int range = Math.Abs(num2 - num1 - 1);
            char[] missingChars = new char[range];

            if (num1 < num2)
            {
                for (int i = num1 + 1; i < num2; i++)
                {
                    Console.Write($"{(Char)i} ");
                }
            }
            else
            {
                for (int i = num2 + 1; i < num1; i++)
                {
                    Console.Write($"{(Char)i} ");
                }
            }
        }
    }
}
