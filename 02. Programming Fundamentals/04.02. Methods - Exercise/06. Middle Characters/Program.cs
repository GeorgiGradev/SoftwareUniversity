using System;

namespace _06._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string result = MiddleCharacter(input);
            Console.WriteLine(result);
        }

        static string MiddleCharacter(string input)
        {
            char[] letters = input.ToCharArray();
            string result = string.Empty;
            if (letters.Length % 2 == 0)
            {
                result = (letters[(letters.Length - 1) / 2]).ToString() + (letters[(letters.Length-1) / 2 + 1]).ToString();
            }
            else
            {
                result = letters[letters.Length / 2].ToString();
            }
            return result;
        }
    }
}

