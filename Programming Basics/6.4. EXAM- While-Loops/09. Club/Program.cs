using System;

namespace _09._Club
{
    class Program
    {
        static void Main(string[] args)
        {
            int expectedProfit = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            int cocktailsNumber = 0;
            double cocktailPrice = 0;
            double total = 0;

            while (command != "Party!")
            {
                cocktailsNumber = int.Parse(Console.ReadLine());
                cocktailPrice = command.Length * cocktailsNumber;

                if (cocktailPrice % 2 != 0)
                {
                    cocktailPrice *= 0.75;
                }
                total += cocktailPrice;
                if (total >= expectedProfit)
                {
                    Console.WriteLine("Target acquired.");
                    break;
                }
                
                command = Console.ReadLine();
            }
            if (command == "Party!")
            {
                Console.WriteLine($"We need {(expectedProfit - total):f2} leva more.");
            }
            Console.WriteLine($"Club income - {total:f2} leva.");
        }
    }
}
