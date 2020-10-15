using System;

namespace _01._National_Court
{
    class Program
    {
        static void Main(string[] args)
        {
            int emp1 = int.Parse(Console.ReadLine());
            int emp2 = int.Parse(Console.ReadLine());
            int emp3 = int.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());
            int peoplePerHour = emp1 + emp2 + emp3;
            int hours = 0;
            while (people > 0)
            {
                hours++;
                 if (hours % 4 != 0)
                {
                    people -= peoplePerHour;
                }
            }
            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}
