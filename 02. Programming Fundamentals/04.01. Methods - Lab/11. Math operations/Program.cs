using System;

namespace _11._Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = int.Parse(Console.ReadLine());
            char operat = char.Parse(Console.ReadLine());
            double num2 = int.Parse(Console.ReadLine());

            double result = MathOperation(num1, operat, num2);
            Console.WriteLine(result);
        }

        static double MathOperation(double num1, char operat, double num2)
        {
            double result = 0;
            if (operat == '/')
            {
                result = num1 / num2;
            }
            else if (operat == '*')
            {
                result = num1 * num2;
            }
            else if (operat == '+')
            {
                result = num1 + num2;
            }
            else if (operat == '-')
            {
                result = num1 - num2;
            }
            return result;
        }
    }
}
