using System;

namespace _10._Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            int emptySeats = 0;
            int studentCounter = 0;
            int standardCounter = 0;
            int kidCounter = 0;
            int totalTickets = 0;
            int currentTickets = 0;
            while (movie != "Finish")
            {
                emptySeats = int.Parse(Console.ReadLine());
                string ticket = Console.ReadLine();


                while (ticket != "End")
                {
                    switch (ticket)
                    {
                        case "student":
                            studentCounter++;
                            break;
                        case "kid":
                            kidCounter++;
                            break;
                        case "standard":
                            standardCounter++;
                            break;
                    }
                    currentTickets++;
                    if (emptySeats == currentTickets)
                    {
                        break;
                    }
                    ticket = Console.ReadLine();
                }
                totalTickets += currentTickets;
                Console.WriteLine($"{movie} - {(currentTickets / (double)emptySeats) * 100:f2}% full.");
                currentTickets = 0;
                movie = Console.ReadLine();
            }
            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{(studentCounter / (double)totalTickets) * 100:f2}% student tickets.");
            Console.WriteLine($"{(standardCounter / (double)totalTickets) * 100:f2}% standard tickets.");
            Console.WriteLine($"{(kidCounter / (double)totalTickets) * 100:f2}% kids tickets.");
        }
    }
}
