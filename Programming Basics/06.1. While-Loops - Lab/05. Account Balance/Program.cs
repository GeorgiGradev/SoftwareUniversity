using System;

namespace _05._Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            int count = 0;

            while (count < n)
            {
                double deposit = double.Parse(Console.ReadLine());
                if (deposit < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                Console.WriteLine($"Increase: {deposit:f2}");
                sum += deposit;
                count++;
            }
            Console.WriteLine($"Total: {sum:f2}");
        }
    }
}
