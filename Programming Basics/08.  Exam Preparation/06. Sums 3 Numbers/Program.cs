using System;

namespace _06._Sums_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int a = 0;
            int b = 0;
            int c = 0;


            if (num1 <= num2 && num1 <= num3)
            {
                a = num1;
            }
            if (num2 <= num1 && num2 <= num3)
            {
                a = num2;
            }
            if (num3 <= num1 && num3 <= num2)
            {
                a = num3;
            }
            if (num1 <= num2 && num1 >= num3)
            {
                b = num1;
            }
            if (num2 <= num1 && num2 >= num3)
            {
                b = num2;
            }
            if (num3 <= num1 && num3 >= num2)
            {
                b = num3;
            }
            if (num1 > num2 && num1 >= num3)
            {
                c = num1;
            }
            if (num2 >= num1 && num2 >= num3)
            {
                c = num2;
            }
            if (num3 >= num1 && num3 >= num2)
            {
                c = num3;
            }


            if (a + b == c)
            {
                Console.WriteLine($"{a} + {b} = {c}");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
