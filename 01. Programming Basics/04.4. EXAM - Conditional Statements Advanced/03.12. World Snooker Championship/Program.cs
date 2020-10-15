using System;

namespace _03._12._World_Snooker_Championship
{
    class Program
    {
        static void Main(string[] args)
        {
            string tourLevel = Console.ReadLine();
            string kindOfTicket = Console.ReadLine();
            int tickets = int.Parse(Console.ReadLine());
            bool ifPicture = Console.ReadLine() == "Y";

            double ticketPrice = 0;

            switch (tourLevel)
            {
                case "Quarter final":
                    {
                        if (kindOfTicket == "Standard")
                        {
                            ticketPrice = 55.5;
                        }
                        else if (kindOfTicket == "Premium")
                        {
                            ticketPrice = 105.20;
                        }
                        else if (kindOfTicket == "VIP")
                        {
                            ticketPrice = 118.90;
                        }
                    }
                    break;
                case "Semi final":
                    {
                        if (kindOfTicket == "Standard")
                        {
                            ticketPrice = 75.88;
                        }
                        else if (kindOfTicket == "Premium")
                        {
                            ticketPrice = 125.22;
                        }
                        else if (kindOfTicket == "VIP")
                        {
                            ticketPrice = 300.40;
                        }
                        break;
                    }
                case "Final":
                    {
                        if (kindOfTicket == "Standard")
                        {
                            ticketPrice = 110.1;
                        }
                        else if (kindOfTicket == "Premium")
                        {
                            ticketPrice = 160.66;
                        }
                        else if (kindOfTicket == "VIP")
                        {
                            ticketPrice = 400;
                        }
                        break;
                    }
            }

            double totalPrice = ticketPrice * tickets;

            if (totalPrice <= 2500)
            {
                if (ifPicture)
                {
                    totalPrice = totalPrice + (tickets * 40);
                }
            }

            if (totalPrice > 2500 && totalPrice <= 4000)
            {
                totalPrice *= 0.90;
                if (ifPicture)
                {
                    totalPrice = totalPrice + (tickets * 40);
                }
            }

            if (totalPrice > 4000)
            {
                totalPrice *= 0.75;
            }


            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}

