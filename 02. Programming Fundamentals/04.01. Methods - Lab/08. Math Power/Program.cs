using System;

namespace _08._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            double output = OnPower(power, number);
            Console.WriteLine(output);
        }

        static double OnPower(int power, double number)
        {
            double result = 1;

            for (int i = 0; i < power; i++)
            {
                result *= number;
            }
            return result;
        }
    }
}
