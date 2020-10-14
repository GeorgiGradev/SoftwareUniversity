using System;

namespace _10._Ski_Trip_
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            string feedback = Console.ReadLine();

            int nights = days - 1;
            double total = 0;

            if (category == "room for one person")
            {
                total = nights * 18;
            }

            else if (category == "apartment")
            {
                if (nights < 10)
                {
                    total = nights * 25 * 0.7;
                }
                else if (nights >= 10 && nights <= 15)
                {
                    total = nights * 25 * 0.65;
                }
                else
                {
                    total = nights * 25 * 0.5;
                }
            }

            else if (category == "president apartment")
            {
                if (nights < 10)
                {
                    total = nights * 35 * 0.9;
                }
                else if (nights >= 10 && nights <= 15)
                {
                    total = nights * 35 * 0.85;
                }
                else
                {
                    total = nights * 35 * 0.8;
                }
            }

            if (feedback == "positive")
            {
                total *= 1.25;
            }
            else if (feedback == "negative")
            {
                total *= 0.90;
            }

            Console.WriteLine($"{total:f2}");

        }
    }
}
