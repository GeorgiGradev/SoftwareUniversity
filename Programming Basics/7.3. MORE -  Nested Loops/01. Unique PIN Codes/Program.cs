using System;

namespace _01._Unique_PIN_Codes
{
    class Program
    {
        static void Main(string[] args)
        {
            int upper1 = int.Parse(Console.ReadLine());
            int upper2 = int.Parse(Console.ReadLine());
            int upper3 = int.Parse(Console.ReadLine());

            for (int num1 = 2; num1 <= upper1; num1++)
            {
                if (num1 % 2 != 0)
                {
                    continue;
                }
                for (int num2 = 2; num2 <= upper2; num2++)
                {
                    for (int i = 2; i <= Math.Sqrt(num2); num2++)
                    {

                        if (num2 % i == 0 || num2 > 7)
                        {
                            break;
                        }
                    }
                    for (int num3 = 2; num3 <= upper3; num3++)
                    {
                        if (num3 % 2 != 0 && num3 == upper3)
                        {
                            continue;
                        }
                        else if (num3 % 2 == 0)
                        {

                            Console.WriteLine($"{num1} {num2} {num3}");
                        }
                    }
                }
            }
        }
    }
}
