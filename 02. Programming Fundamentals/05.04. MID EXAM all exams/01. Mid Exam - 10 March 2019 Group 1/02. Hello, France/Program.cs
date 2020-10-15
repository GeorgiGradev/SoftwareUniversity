using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;

namespace _02._Hello__France
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(new String[] { "->", "|" }, StringSplitOptions.RemoveEmptyEntries);
            decimal budget = decimal.Parse(Console.ReadLine());
            List<decimal> oldList = new List<decimal>();
            List<decimal> newList = new List<decimal>();

            string item = string.Empty;
            decimal itemPrice = 0;
            decimal profit = 0;

            for (int i = 0; i < input.Length; i++)
            {
                decimal newPrice = 0;
                if (i % 2 == 0)
                {
                    item = input[i];
                }
                else
                {
                    itemPrice = decimal.Parse(input[i]);

                    if ((item == "Clothes" && itemPrice > 50)
                        || (item == "Shoes" && itemPrice > 35)
                        || (item == "Accessories" && itemPrice > 20.5M))
                    {
                        continue;
                    }

                    else if (budget >= itemPrice)
                    {
                        budget -= itemPrice;
                        newPrice = itemPrice * 1.4M;
                        oldList.Add(itemPrice);
                        newList.Add(newPrice);

                    }
                }
            }
            profit = newList.Sum() - oldList.Sum();
            budget += newList.Sum();

            foreach (var element in newList)
            {
                Console.Write($"{element:f2} ");
            }
            Console.WriteLine();

            Console.WriteLine($"Profit: {profit:f2}");

            if (budget >= 150)
            {
                Console.WriteLine("Hello, France!");
            }
            else
            {
                Console.WriteLine("Time to go.");
            }
        }
    }
}

