using System;
using System.Linq;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int finalResult = SubtractMethod(num1, num2, num3);
            Console.WriteLine(finalResult);
        }

        static int SumMethod(int num1, int num2)
        {
            int resultSum = num1 + num2;
            return resultSum;
        }

        static int SubtractMethod(int num1, int num2, int num3)
        {
            int resultSubtract = SumMethod(num1, num2) - num3;

            return resultSubtract;
        }
    }
}
