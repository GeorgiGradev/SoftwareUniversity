using System;
using System.Linq;
namespace _04._Password_Validator
{
    class Program // BOOL PROBLEM !!!!
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            if (!IsBetween(password))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (!CharactersDigits(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (!Digits(password))
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (IsBetween(password) && CharactersDigits(password) && Digits(password))
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool IsBetween(string password)
        {
            char[] symbols = password.ToCharArray();
            bool isBetween = true;
            if (symbols.Length < 6 || symbols.Length > 10)
            {
                isBetween = false;
            }
            return isBetween;
        }

        static bool CharactersDigits(string password)
        {
            char[] symbols = password.ToCharArray();
            bool hasCharactersDigits = true;
            for (int i = 0; i < symbols.Length; i++)
            {
                if (symbols[i] >= 'a' && symbols[i] <= 'z'
                    || symbols[i] >= 'A' && symbols[i] <= 'Z' 
                    || symbols[i] >= '0' && symbols[i] <= '9')
                {
                    hasCharactersDigits = true;
                }
                else
                {
                    hasCharactersDigits = false;
                    break;
                }
            }
            return hasCharactersDigits;
        }

        static bool Digits(string password)
        {
            int digitCounter = 0;
            char[] symbols = password.ToCharArray();
            bool has2Digits = false;
            for (int i = 0; i < symbols.Length; i++)
            {
                if (symbols[i] >= '0' && symbols[i] <= '9')
                {
                    digitCounter++;
                    if (digitCounter >= 2)
                    {
                        has2Digits = true;
                        break;
                    }
                }
            }
            return has2Digits;
        }
    }
} 
