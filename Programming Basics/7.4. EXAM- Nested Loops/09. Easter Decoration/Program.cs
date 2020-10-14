using System;

namespace _09._Easter_Decoration
{
    class Program
    {
        static void Main(string[] args)
        {
            int clients = int.Parse(Console.ReadLine());
            double totalSum = 0;

            for (int i = 0; i < clients; i++)
            {
                string purchaseCommand = Console.ReadLine();
                double sum = 0;
                int productCounter = 0;
                while (purchaseCommand != "Finish")
                {
                    productCounter++;
                    switch (purchaseCommand)
                    {
                        case "basket":
                            sum += 1.5;
                            break;
                        case "wreath":
                            sum += 3.8;
                            break;
                        case "chocolate bunny":
                            sum += 7;
                            break;
                    }
                    purchaseCommand = Console.ReadLine();
                }
                if (productCounter % 2 == 0)
                {
                    sum *= 0.8;
                }
                Console.WriteLine($"You purchased {productCounter} items for {sum:f2} leva.");
                totalSum += sum;

            }
            Console.WriteLine($"Average bill per client is: {totalSum / clients:f2} leva.");
        }
    }
}
