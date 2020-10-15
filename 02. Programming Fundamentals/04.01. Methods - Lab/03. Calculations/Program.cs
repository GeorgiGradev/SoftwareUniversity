using System;

namespace REDO_03._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string calculator = Console.ReadLine();
            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());
            double result = 0;
            Calculations(calculator, result, number1, number2);
        }

        static void Calculations(string calculator, double result, double number1, double number2)
        {
            if (calculator == "add")
            {
                result = number1 + number2;
            }
            else if (calculator == "multiply")
            {
                result = number1 * number2;
            }
            else if (calculator == "subtract")
            {
                result = number1 - number2;
            }
            else if (calculator == "divide")
            {
                result = number1 / number2;
            }
            Console.WriteLine(result);
        }
    }
}
