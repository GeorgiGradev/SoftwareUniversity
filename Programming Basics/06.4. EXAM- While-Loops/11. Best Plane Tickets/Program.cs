using System;

namespace _11._Best_Plane_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string ticketORcommand = Console.ReadLine();
            double priceEuro = 0;
            int minutesStay = 0;
            int minimumStay = int.MaxValue;
            double priceLeva = 0;
            int hours = 0;
            int minutes = 0;
            string ticketNumber = "";

            while (ticketORcommand != "End")
            {
                priceEuro = double.Parse(Console.ReadLine());
                minutesStay = int.Parse(Console.ReadLine());
                
                if (minutesStay < minimumStay)
                {
                    minimumStay = minutesStay;
                    ticketNumber = ticketORcommand;
                    priceLeva = priceEuro * 1.96;
                    minutes = minimumStay % 60;
                    hours = minimumStay / 60;
                }
                ticketORcommand = Console.ReadLine();
                
            }
            Console.WriteLine($"Ticket found for flight {ticketNumber} costs {priceLeva:f2} leva with {hours}h {minutes}m stay");
        }
    }
}
