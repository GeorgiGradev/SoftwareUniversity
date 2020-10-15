using System;

namespace _02._Print_Numbers_in_Reverse_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] numbers = new string[n];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Console.ReadLine();
            }

            for (int i = n-1; i >= 0; i--)
            {
                Console.Write($"{numbers[i]} ");
            }
        }
    }
}
