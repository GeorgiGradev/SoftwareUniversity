using System;

namespace _02._Report_System
{
    class Program
    {
        static void Main(string[] args)
        {
            int neededSum = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            
            int counter = 0;
            int cash = 0;
            int creditCard = 0;
            int cashCounter = 0;
            int cardCounter = 0;

            while (command != "End")
            {
                int itemPrice = int.Parse(command);
                counter++;

                if (counter % 2 != 0)  // cash
                {
                    if (itemPrice <= 100)
                    {
                        neededSum -= itemPrice;
                        cash += itemPrice;
                        cashCounter++;
                        Console.WriteLine("Product sold!");
                    }
                    else
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                }
                else if (counter % 2 == 0) // card
                {
                    if (itemPrice > 10)
                    {
                        neededSum -= itemPrice;
                        creditCard += itemPrice;
                        cardCounter++;
                        Console.WriteLine("Product sold!");
                    }
                    else
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                }
                if (neededSum <= 0)
                {
                    Console.WriteLine($"Average CS: {cash * 1.0/cashCounter:f2}");
                    Console.WriteLine($"Average CC: {creditCard * 1.0 / cardCounter:f2}");
                    break;
                }
                command = Console.ReadLine();
            }
            if (command == "End")
            {
                Console.WriteLine("Failed to collect required money for charity.");
            }
        }
    }
}
