using System;

namespace _05._02._Time___15_min
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());


            int timeInMinutes = hours * 60 + minutes;
            int timeInMinutesAfter15 = timeInMinutes + 15;

            int hourAfter15 = timeInMinutesAfter15 / 60;
            int minutesAfter15 = timeInMinutesAfter15 % 60;

            if (hourAfter15 == 24)
            {
                hourAfter15 = 0;
            }
            Console.WriteLine($"{hourAfter15}:{minutesAfter15:D2}");
        }
    }
}
