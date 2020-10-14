using System;

namespace _03._03._Coffee_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string drink = Console.ReadLine();
            string sugar = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            double price = 0;

            switch (drink)
            {
                case "Espresso":
                    {
                        if (sugar == "Without")
                        {
                            price = quantity * 0.9;
                        }
                        else if (sugar == "Normal")
                        {
                            price = quantity * 1;
                        }
                        else if (sugar == "Extra")
                        {
                            price = quantity * 1.20;
                        }
                        if (quantity >= 5)
                        {
                            price *= 0.75;
                        }
                    }
                    break;
                case "Cappuccino":
                    {
                        if (sugar == "Without")
                        {
                            price = quantity * 1;
                        }
                        else if (sugar == "Normal")
                        {
                            price = quantity * 1.20;
                        }
                        else if (sugar == "Extra")
                        {
                            price = quantity * 1.60;
                        }
                        break;
                    }
                case "Tea":
                    {
                        if (sugar == "Without")
                        {
                            price = quantity * 0.50;
                        }
                        else if (sugar == "Normal")
                        {
                            price = quantity * 0.60;
                        }
                        else if (sugar == "Extra")
                        {
                            price = quantity * 0.70;
                        }
                        break;
                    }
            }

            if (sugar == "Without")
            {
                price *= 0.65;
            }
            if (price > 15)
            {
                price *= 0.80;
            }

            Console.WriteLine($"You bought {quantity} cups of {drink} for {price:F2} lv.");
        }
    }
}
