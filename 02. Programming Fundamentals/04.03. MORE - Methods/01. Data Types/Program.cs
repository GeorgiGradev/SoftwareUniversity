using System;

namespace _01._Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            C            string input = Console.ReadLine();

            if (input == "int")
            {
                int result = Integer(input);
                Console.WriteLine(result);
            }
            else if (input == "real")
            {
                double result = Real(input);
                Console.WriteLine($"{result:f2}");
            }
            else if (input == "string")
            {
                string result = Text(input);
                Console.WriteLine(result);
            }
        }

        static int Integer(string input)
        {
            int num = int.Parse(Console.ReadLine());
            int result = 2 * num;
            return result;
        }

        static double Real(string input)
        {
            double num = double.Parse(Console.ReadLine());
            double result = 1.5 * num;
            return result;
        }

        static string Text(string input)
        {
            string secondInput = Console.ReadLine();
            string result = "$" + secondInput + "$";
            return result;
        }
    }
}
