using System;

namespace _06._Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            int people = 0;
            int income = 0;
            bool fullCinema = false;
 
            while (command != "Movie time!")
            {
                people = int.Parse(command);
                capacity -= people;
                if (capacity < 0)
                {
                    Console.WriteLine("The cinema is full.");
                    fullCinema = true;
                    break;
                }
                if (people % 3 == 0)
                {
                    income += (people * 5) - 5;
                }
                else
                {
                    income += (people * 5);
                }
                command = Console.ReadLine();
            }
            if (!fullCinema)
            {
                Console.WriteLine($"There are {capacity} seats left in the cinema.");
            }
                Console.WriteLine($"Cinema income - {income} lv.");
        }
    }
}
