using System;

namespace _03._02._Cruise_Ship
{
    class Program
    {
        static void Main(string[] args)
        {
            string cruise = Console.ReadLine();
            string cabin = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double price = 1;

            if (nights > 7)
            {
                price = price * 0.75;
            }
            switch (cruise)
            {
                case "Mediterranean":
                    {
                        if (cabin == "standard cabin")
                        {
                            price = 27.5 * nights * 4;
                        }
                        else if (cabin == "cabin with balcony")
                        {
                            price = 30.2 * nights * 4;
                        }
                        else if (cabin == "apartment")
                        {
                            price = 40.50 * nights * 4;
                        }
                        if (nights > 7)
                        {
                            price = price * 0.75;
                        }
                        Console.WriteLine($"Annie's holiday in the Mediterranean sea costs {price:F2} lv.");
                        break;
                    }
                case "Adriatic":
                    {
                        if (cabin == "standard cabin")
                        {
                            price = 22.99 * nights * 4;
                        }
                        else if (cabin == "cabin with balcony")
                        {
                            price = 25 * nights * 4;
                        }
                        else if (cabin == "apartment")
                        {
                            price = 34.99 * nights * 4;
                        }
                        if (nights > 7)
                        {
                            price = price * 0.75;
                        }
                        Console.WriteLine($"Annie's holiday in the Adriatic sea costs {price:F2} lv.");
                        break;
                        
                    }
                case "Aegean":
                    {
                        if (cabin == "standard cabin")
                        {
                            price = 23.00 * nights * 4;
                        }
                        else if (cabin == "cabin with balcony")
                        {
                            price = 26.6 * nights * 4;
                        }
                        else if (cabin == "apartment")
                        {
                            price = 39.80 * nights * 4;
                        }
                        if (nights > 7)
                        {
                            price = price * 0.75;
                        }
                        Console.WriteLine($"Annie's holiday in the Aegean sea costs {price:F2} lv.");
                        break;
            
                    }
            }



            

        }
    }
}
