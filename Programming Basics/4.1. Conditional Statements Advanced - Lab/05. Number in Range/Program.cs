using System;

namespace _05._Number_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());

            if ((number >= -100 && number <= 100) && number != 0)
            {
                Console.WriteLine("Yes");
            }
            else
                Console.WriteLine("No");
        }

    }
}
