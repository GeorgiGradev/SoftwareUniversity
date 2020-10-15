using System;

namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int result = GetMultipleOfEvenAndOdds(input);
            Console.WriteLine(result);
        }

        static int GetMultipleOfEvenAndOdds(int input)
        {
            int sumOfEven = GetSumOfEvenDigits(input);
            int sumOfOdds = GetSumOfOddDigits(input);

            int result = sumOfEven * sumOfOdds;
            return result;
        }

        static int GetSumOfEvenDigits(int input)
        {
            int sumEven = 0;
            input = Math.Abs(input);
            while (input > 0)
            {
                if (input % 2 == 0)
                {
                    sumEven += input % 10;
                    input = input / 10;
                }
                else
                {
                    input = input / 10;
                }
            }
            return sumEven;
        }

        static int GetSumOfOddDigits(int input)
        {
            int sumOdd = 0;
            input = Math.Abs(input);
            while (input > 0)
            {
                if (input % 2 != 0)
                {
                    sumOdd += input % 10;
                    input = input / 10;
                }
                else
                {
                    input = input / 10;
                }
            }
            return sumOdd;
        }
    }
}
