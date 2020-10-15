using System;

namespace _07._School_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string group = Console.ReadLine();
            int kids = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());

            string sport = "0";
            double price = 0;
            double totalPrice = 0;

            if (season == "Winter")
            {
                if (group == "girls")
                {
                    sport = "Gymnastics";
                    price = kids * 9.60;
                }
                else if (group == "boys")
                {
                    sport = "Judo";
                    price = kids * 9.60;

                }
                else if (group == "mixed")
                {
                    sport = "Ski";
                    price = kids * 10;
                }
            }
            else if (season == "Spring")
            {
                if (group == "girls")
                {
                    sport = "Athletics";
                    price = kids * 7.20;
                }
                else if (group == "boys")
                {
                    sport = "Tennis";
                    price = kids * 7.20;

                }
                else if (group == "mixed")
                {
                    sport = "Cycling";
                    price = kids * 9.50;
                }
            }
            else if (season == "Summer")
            {
                if (group == "girls")
                {
                    sport = "Volleyball";
                    price = kids * 15;
                }
                else if (group == "boys")
                {
                    sport = "Football";
                    price = kids * 15;

                }
                else if (group == "mixed")
                {
                    sport = "Swimming";
                    price = kids * 20;
                }
            }

            if (kids < 10)
            {
                totalPrice = nights * price;
            }
            else if (kids >= 10 && kids < 20)
            {
                totalPrice = nights * price * 0.95;
            }
            else if (kids >= 20 && kids < 50)
            {
                totalPrice = nights * price * 0.85;
            }
            else
            {
                totalPrice = nights * price * 0.50;
            }

            Console.WriteLine($"{sport} {totalPrice:F2} lv.");
           
        }
    }
}
