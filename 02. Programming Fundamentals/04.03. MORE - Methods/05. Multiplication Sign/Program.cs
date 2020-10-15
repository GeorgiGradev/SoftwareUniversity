using System;

namespace _05._Multiplication_Sign
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine(MultiplicationSign(num1, num2, num3));

        }

        static string MultiplicationSign(int num1, int num2, int num3)
        {
            string output = string.Empty;

            if (num1 == 0 || num2 == 0 || num3 == 0)
            {
                output = "zero";
            }
            else if ((num1 > 0 && num2 > 0 && num3 < 0)
                || (num1 > 0 && num2 < 0 && num3 > 0)
                || (num1 < 0 && num2 > 0 && num3 > 0)
                || (num1 < 0 && num2 < 0 && num3 < 0))
            {
                output = "negative";
            }
            else 
            {
                output = "positive";
            }


            return output;
        }
    }
}
