using System;

namespace _05._Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string digits = string.Empty;
            string chars = string.Empty;
            string others = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                char p = input[i];
                if (char.IsDigit(p))
                {
                    digits += p;
                }
                else if (char.IsLetter(p))
                {
                    chars += p;
                }
                else
                {
                    others += p;
                }

            }
            Console.WriteLine(digits);
            Console.WriteLine(chars);
            Console.WriteLine(others);
        }
    }
}
