using System;

namespace _02._From_Left_to_The_Right
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            long greaterNumber = 0;

            for (int i = 0; i < number; i++)
            {
                string input = Console.ReadLine();

                string leftHalf = String.Empty;
                string rightHalf = String.Empty;
                bool isFirstNumber = true;

                for (int k = 0; k < input.Length; k++)
                {
                    if (isFirstNumber && input[k] != ' ')
                    {
                        leftHalf += input[k];
                    }
                    else if (!isFirstNumber && input[k] != ' ')
                    {
                        rightHalf += input[k];
                    }
                    else if (input[k] == ' ')
                    {
                        isFirstNumber = false;
                    }
                }

                long firstNumber = long.Parse(leftHalf);
                long secondNumber = long.Parse(rightHalf);

                greaterNumber = Math.Max(firstNumber, secondNumber);

                long sum = 0;

                while (greaterNumber != 0)
                {
                    sum += greaterNumber % 10;
                    greaterNumber /= 10;
                }

                Console.WriteLine(Math.Abs(sum));
            }
        }
    }
}
