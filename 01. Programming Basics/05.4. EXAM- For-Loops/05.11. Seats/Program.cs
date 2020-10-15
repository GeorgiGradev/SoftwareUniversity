using System;

namespace P05_Seats
{
    class P05_Seats
    {
        static void Main(string[] args)
        {
            int ticketsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < ticketsCount; i++)
            {
                string ticketNumber = Console.ReadLine();

                int lenght = ticketNumber.Length;
                string seat = "";

                if (lenght == 4)
                {
                    if (ticketNumber[0] >= 'A' && ticketNumber[0] <= 'Z')
                    {
                        seat = seat + ticketNumber[0];
                    }
                    else
                    {
                        seat = seat + ticketNumber[3];
                    }
                    seat = seat + ticketNumber[1];
                    seat = seat + ticketNumber[2];
                }
                else if (lenght == 5 || lenght == 6)
                {
                    seat = seat + ticketNumber[0];
                    seat = seat + (int)ticketNumber[1];
                }

                Console.WriteLine($"Seat decoded: {seat}");
            }
        }
    }
}
