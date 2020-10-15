using System;

namespace _03._10._Oscars_week_in_cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            string room = Console.ReadLine();
            int tickets = int.Parse(Console.ReadLine());

            double price = 0;

            if (movie == "A Star Is Born" && room == "normal")
            {
                price = 7.50;
            }
            else if (movie == "A Star Is Born" && room == "luxury")
            {
                price = 10.5;
            }
            else if (movie == "A Star Is Born" && room == "ultra luxury")
            {
                price = 13.50;
            }
            else if (movie == "Bohemian Rhapsody" && room == "normal")
            {
                price = 7.35;
            }
            else if (movie == "Bohemian Rhapsody" && room == "luxury")
            {
                price = 9.45;
            }
            else if (movie == "Bohemian Rhapsody" && room == "ultra luxury")
            {
                price = 12.75;
            }
            else if (movie == "Green Book" && room == "normal")
            {
                price = 8.15;
            }
            else if (movie == "Green Book" && room == "luxury")
            {
                price = 10.25;
            }
            else if (movie == "Green Book" && room == "ultra luxury")
            {
                price = 13.25;
            }
            else if (movie == "The Favourite" && room == "normal")
            {
                price = 8.75;
            }
            else if (movie == "The Favourite" && room == "luxury")
            {
                price = 11.55;
            }
            else if (movie == "The Favourite" && room == "ultra luxury")
            {
                price = 13.95;
            }
            double totalPrice = price * tickets;
            Console.WriteLine($"{movie} -> {totalPrice:F2} lv.");
        }
    }
}
