using System;

namespace _03._Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int total = 0;

            while (input != "Stop")
            {
                int inputToNumber = int.Parse(input);
                total += inputToNumber;
                input = Console.ReadLine();
            }

            Console.WriteLine(total);
        }
    }
}
