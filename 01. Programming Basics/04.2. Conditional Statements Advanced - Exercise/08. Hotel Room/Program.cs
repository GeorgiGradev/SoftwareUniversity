using System;

namespace _08._Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());

            double studio = 0;
            double apartment = 0;

            if (month == "May" || month == "October")
            {
                if (days <= 7)
                {
                    studio = 50;
                    apartment = 65;
                }
                if (days > 7 && days <= 14)
                {
                    studio = 50 * 0.95;
                    apartment = 65;
                }
                if (days > 14)
                {
                    studio = 50 * 0.7;
                    apartment = 65 * 0.9;
                }
            }
            else if (month == "June" || month == "September")
            {
                if (days <= 14)
                {
                    studio = 75.2;
                    apartment = 68.7;
                }
                else if (days > 14)
                {
                    studio = 75.2 * 0.8;
                    apartment = 68.7 * 0.9;
                }
            }
            else if (month == "July" || month == "August")
            {

           
                if (days <= 14)
                {
                    studio = 76;
                    apartment = 77;
                }
                else if (days > 14)
                {
                    studio = 76;
                    apartment = 77 * 0.9;
                }
            }
            Console.WriteLine($"Apartment: {days * apartment:F2} lv.");
            Console.WriteLine($"Studio: {days * studio:F2} lv.");
        }
    }
}
