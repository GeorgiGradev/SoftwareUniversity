using System;

namespace _03._Tourist_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string commandORproduct = Console.ReadLine();
            double productPrice = 0;
            int productCounter = 0;
            double totalPrice = 0;

            while (commandORproduct != "Stop")
            {
                productPrice = double.Parse(Console.ReadLine());
                productCounter++;
                if (productCounter % 3 != 0)
                {
                    totalPrice += productPrice;
                    if(totalPrice > budget)
                    {
                        break;
                    }
                }
                else
                {
                    totalPrice += (productPrice / 2);
                    if (totalPrice > budget)
                    {
                        break;
                    }
                }
                commandORproduct = Console.ReadLine();
            }
           
            if (commandORproduct == "Stop")
            {
                Console.WriteLine($"You bought { productCounter} products for {totalPrice:f2} leva.");
            }
            if (totalPrice > budget)
            {
                Console.WriteLine("You don't have enough money!");
                Console.WriteLine($"You need {totalPrice - budget:f2} leva!");
            }


        }
    }
}
