using System;

namespace _03._05._Film_Premiere
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            string package = Console.ReadLine();
            int tickets = int.Parse(Console.ReadLine());

            double price = 0;

            switch (movie)
            {
                case "John Wick":
                    {
                        if (package == "Drink")
                        {
                            price = 12 * tickets;
                        }
                        else if (package == "Popcorn")
                        {
                            price = 15 * tickets;
                        }
                        else if (package == "Menu")
                        {
                            price = 19 * tickets;
                        }
                        break;
                    }
                case "Star Wars":
                    {
                        if (package == "Drink")
                        {
                            price = 18 * tickets;
                        }
                        else if (package == "Popcorn")
                        {
                            price = 25 * tickets;
                        }
                        else if (package == "Menu")
                        {
                            price = 30 * tickets;
                        }
                        break;
                    }
                case "Jumanji":
                    {
                        if (package == "Drink")
                        {
                            price = 9 * tickets;
                        }
                        else if (package == "Popcorn")
                        {
                            price = 11 * tickets;
                        }
                        else if (package == "Menu")
                        {
                            price = 14 * tickets;
                        }
                        break;
                    }
            }
            if (tickets >= 4 && movie == "Star Wars")
            {
                price *= 0.70;
            }
            if (tickets == 2 && movie == "Jumanji")
            {
                price *= 0.85;
            }
            Console.WriteLine($"Your bill is {price:F2} leva.");
        }
    }
}
