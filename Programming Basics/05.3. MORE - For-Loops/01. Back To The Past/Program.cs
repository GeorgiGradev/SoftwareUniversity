using System;

namespace _01._Back_To_The_Past
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int evenCount = 0;
            int oddCount = 0;

            for (int i = 1800; i <= year; i++)
            {
                if (i % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
            }
            double total = (oddCount * (12000 + (50* (18+oddCount))) + (evenCount * 12000));
            double diff = Math.Abs(money - total);

            if (money >= total)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {diff:F2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {diff:F2} dollars to survive.");
            }
        }
    }
}
