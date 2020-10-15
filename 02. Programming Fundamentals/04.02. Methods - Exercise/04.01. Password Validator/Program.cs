using System;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool isTrue = true;
            IsTrue(password, isTrue);
            IsBetween(password, isTrue);
            CharactersDigits(password, isTrue);
            Digits(password, isTrue);

        }

        static void IsBetween(string password, bool isTrue)
        {
            isTrue = true;
            char[] symbols = password.ToCharArray();
            if (symbols.Length < 6 || symbols.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                isTrue = false;
            }
        }

        static void CharactersDigits(string password, bool isTrue)
        {
            isTrue = true;
            char[] symbols = password.ToCharArray();
            for (int i = 0; i < symbols.Length; i++)
            {
                if (symbols[i] >= 'a' && symbols[i] <= 'z'
                    || symbols[i] >= 'A' && symbols[i] <= 'Z'
                    || symbols[i] >= '0' && symbols[i] <= '9')
                {

                }
                else
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                    isTrue = false;
                    break;
                }
            }
        }

        static void Digits(string password, bool isTrue)
        {
            isTrue = true;
            int digitCounter = 0;
            char[] symbols = password.ToCharArray();
            for (int i = 0; i < symbols.Length; i++)
            {
                if (symbols[i] >= '0' && symbols[i] <= '9')
                {
                    digitCounter++;
                }
            }
            if (digitCounter < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                isTrue = false;
            }
        }

        static void IsTrue(string password, bool isTrue)
        {

            IsBetween(password, isTrue);
            CharactersDigits(password, isTrue);
            Digits(password, isTrue);
            if (isTrue)
            {
                Console.WriteLine("Password is valid");
            }
        }
    }
}

