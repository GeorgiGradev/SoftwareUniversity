using System;

namespace _07._Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            int emptySeats = 0;
            string ticket = "";

            int studentCounter = 0;
            int standardCounter = 0;
            int kidCounter = 0;
            int totalStudentCounter = 0;
            int totalStandardCounter = 0;
            int totalKidCounter = 0;
            int allTickets = 0;

            while (movie != "Finish")
            {
                emptySeats = int.Parse(Console.ReadLine());

                for (int i = 0; i < emptySeats; i++)
                {
                    ticket = Console.ReadLine();

                    if (ticket == "student")
                    {
                        studentCounter++;
                    }
                    else if (ticket == "standard")
                    {
                        standardCounter++;
                    }
                    else if (ticket == "kid")
                    {
                        kidCounter++;
                    }
                    allTickets = studentCounter + standardCounter + kidCounter;
                    if (ticket == "End")
                    {
                        Console.WriteLine($"{movie} - {(allTickets / (double)emptySeats) * 100:f2}% full.");
                        break;
                    }
                    if (emptySeats == allTickets)
                    {
                        Console.WriteLine($"{movie} - {(allTickets / (double)emptySeats) * 100:f2}% full.");
                        break;
                    }

                }
                totalStudentCounter += studentCounter;
                totalStandardCounter += standardCounter;
                totalKidCounter += kidCounter;
                studentCounter = 0;
                standardCounter = 0;
                kidCounter = 0;

                movie = Console.ReadLine();
            }
            int Totaltickets = totalStudentCounter + totalStandardCounter + totalKidCounter;
            Console.WriteLine($"Total tickets: {Totaltickets}");
            Console.WriteLine($"{(totalStudentCounter / (double)Totaltickets) * 100:f2}% student tickets.");
            Console.WriteLine($"{(totalStandardCounter / (double)Totaltickets) * 100:f2}% standard tickets.");
            Console.WriteLine($"{(totalKidCounter / (double)Totaltickets) * 100:f2}% kids tickets.");
        }
    }
}
