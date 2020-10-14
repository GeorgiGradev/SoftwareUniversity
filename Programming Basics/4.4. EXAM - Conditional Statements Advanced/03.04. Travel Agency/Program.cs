using System;

namespace P03_TravelAgency
{
    class P03_TravelAgency
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            string package = Console.ReadLine();
            bool hasVIP = Console.ReadLine() == "yes";
            int days = int.Parse(Console.ReadLine());

            bool isValid = true;
            double price = 0.0;

            if (days > 7)
            {
                days--;
            }

            switch (town)
            {
                case "Bansko":
                case "Borovets":
                    if (hasVIP)
                    {
                        if (package == "noEquipment")
                        {
                            price = 80 * 0.95;
                        }
                        else if (package == "withEquipment")
                        {
                            price = 100 * 0.9;
                        }
                        else
                        {
                            isValid = false;
                        }
                    }
                    else
                    {
                        if (package == "noEquipment")
                        {
                            price = 80;
                        }
                        else if (package == "withEquipment")
                        {
                            price = 100;
                        }
                        else
                        {
                            isValid = false;
                        }
                    }
                    break;
                case "Varna":
                case "Burgas":
                    if (hasVIP)
                    {
                        if (package == "withBreakfast")
                        {
                            price = 130 * 0.88;
                        }
                        else if (package == "noBreakfast")
                        {
                            price = 100 * 0.92;
                        }
                        else
                        {
                            isValid = false;
                        }
                    }
                    else
                    {
                        if (package == "withBreakfast")
                        {
                            price = 130;
                        }
                        else if (package == "noBreakfast")
                        {
                            price = 100;
                        }
                        else
                        {
                            isValid = false;
                        }
                    }
                    break;
                default:
                    isValid = false;
                    break;
            }
            if (!isValid)
            {
                Console.WriteLine("Invalid input!");
            }
            else if (days < 1)
            {
                Console.WriteLine("Days must be positive number!");
            }
            else
            {
                double finalPrice = days * price;
                Console.WriteLine($"The price is {finalPrice:F2}lv! Have a nice time!");
            }
        }
    }
}
