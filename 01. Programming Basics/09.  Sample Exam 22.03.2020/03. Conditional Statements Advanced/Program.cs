using System;

namespace _03._Conditional_Statements_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            string sushiKind = Console.ReadLine(); ;
            string restaurantName = Console.ReadLine(); ;
            int portions = int.Parse(Console.ReadLine());
            char order = char.Parse(Console.ReadLine());
            double price = 0;
            
            if (restaurantName == "Sushi Zone")
            {
                if (sushiKind == "sashimi")
                {
                    price += portions * 4.99;
                }
                else if (sushiKind == "maki")
                {
                    price += portions * 5.29;
                }
                else if (sushiKind == "uramaki")
                {
                    price += portions * 5.99;
                }
                else if (sushiKind == "temaki")
                {
                    price += portions * 4.29;
                }
            }
            else if (restaurantName == "Sushi Time")
            {
                if (sushiKind == "sashimi")
                {
                    price += portions * 5.49;
                }
                else if (sushiKind == "maki")
                {
                    price += portions * 4.69;
                }
                else if (sushiKind == "uramaki")
                {
                    price += portions * 4.49;
                }
                else if (sushiKind == "temaki")
                {
                    price += portions * 5.19;
                }
            }
            else if (restaurantName == "Sushi Bar")
            {
                if (sushiKind == "sashimi")
                {
                    price += portions * 5.25;
                }
                else if (sushiKind == "maki")
                {
                    price += portions * 5.55;
                }
                else if (sushiKind == "uramaki")
                {
                    price += portions * 6.25;
                }
                else if (sushiKind == "temaki")
                {
                    price += portions * 4.75;
                }
            }
            else if (restaurantName == "Asian Pub")
            {
                if (sushiKind == "sashimi")
                {
                    price += portions * 4.50;
                }
                else if (sushiKind == "maki")
                {
                    price += portions * 4.80;
                }
                else if (sushiKind == "uramaki")
                {
                    price += portions * 5.50;
                }
                else if (sushiKind == "temaki")
                {
                    price += portions * 5.50;
                }
            }
            else 
            {
                Console.WriteLine($"{restaurantName} is invalid restaurant!");
                return;
            }

            if (order == 'Y')
            {
                price = price + (price * 0.20);
            }
            Console.WriteLine($"Total price: {Math.Ceiling(price)} lv.");
        }
    }
}
