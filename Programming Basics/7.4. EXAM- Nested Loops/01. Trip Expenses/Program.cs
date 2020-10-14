using System;

namespace _01._Trip_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int vacationLenght = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int dayCounter = 0;
            int productCounter = 0;
            double dayLimit = 60;
            double savedMoney = 0;
            double productPrice = 0;


            while (vacationLenght != dayCounter)
            {
                dayCounter++;

                while (command != "Day over" && dayLimit > 0)
                {
                    productPrice = double.Parse(command);
                    dayLimit -= productPrice;

                    if (dayLimit >= 0)
                    {
                        productCounter++;
                    }
                    if (dayLimit == 0)
                    {
                        Console.WriteLine($"Daily limit exceeded! You've bought {productCounter} products.");
                        dayLimit = 60;
                        productCounter = 0;
                        command = Console.ReadLine();
                        break;
                    }
                    else if (dayLimit <= 0)
                    {
                        dayLimit += productPrice;
                        command = Console.ReadLine();
                        continue;
                    }
                    command = Console.ReadLine();
                    if (command == "Day over" && dayLimit >= 0)
                    {
                        savedMoney = dayLimit;
                        Console.WriteLine($"Money left from today: {savedMoney:f2}. You've bought {productCounter} products.");
                        command = Console.ReadLine();
                        productCounter = 0;
                        dayLimit = 60 + savedMoney;
                        break;
                    }

                }
                if (command == "Day over" && vacationLenght >= dayCounter)
                {
                    savedMoney = dayLimit;
                    dayLimit = 60 + savedMoney;
                    Console.WriteLine($"Money left from today: {savedMoney:f2}. You've bought {productCounter} products.");
                    productCounter = 0;
                    command = Console.ReadLine();
                }

            }
        }
    }
}