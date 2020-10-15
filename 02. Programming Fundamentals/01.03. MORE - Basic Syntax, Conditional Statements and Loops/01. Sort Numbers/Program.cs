using System;

namespace _01._Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.MinValue;
            int num2 = int.MinValue;
            int num3 = int.MinValue;

            for (int i = 0; i < 3; i++)
            {
                int input = int.Parse(Console.ReadLine());
                if (input > num1)
                {
                    num3 = num2;
                    num2 = num1;
                    num1 = input;
                }
                else if (input > num2)
                {
                    num3 = num2;
                    num2 = input;
                }
                else if (input > num3)
                {
                    num3 = input;
                }
            }
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
        }
    }
}
