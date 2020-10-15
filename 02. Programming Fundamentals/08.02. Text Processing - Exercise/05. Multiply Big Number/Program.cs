using System;
using System.Linq;
using System.Text;

namespace _05._Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string longNum = Console.ReadLine();// 9999 
            int num = int.Parse(Console.ReadLine()); // 9
            StringBuilder sb = new StringBuilder();
            int temp = 0;

            foreach (char ch in longNum.Reverse())
            {
                int digit = int.Parse(ch.ToString()); // 9
                int result = digit * num + temp; // 89
                int resDigit = result % 10; // 8

                sb.Insert(0, resDigit);
                temp = result / 10; // 9
            }

            if (temp > 0)
            {
                sb.Insert(0, temp);
            }

            string finalNumber = sb.ToString().TrimStart('0');

            if (finalNumber.Length == 0)
            {
                finalNumber = "0";
            }

            Console.WriteLine(finalNumber);
        }
    }
}
