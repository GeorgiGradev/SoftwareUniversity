using System;

namespace _02._Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            string numStr = Console.ReadLine();
            int sum = 0;
            int num = int.Parse(numStr);

            while (num > 0)
            {
                sum += num % 10;
                num = num / 10;
            }
            Console.WriteLine(sum);
        }
    }
}

