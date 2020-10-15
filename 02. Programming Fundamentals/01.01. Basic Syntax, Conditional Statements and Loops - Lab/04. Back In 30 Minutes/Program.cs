using System;

namespace _04._Back_In_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int hoursInMinutes = hours * 60;
            int totalTimeInMinutes = minutes + hoursInMinutes + 30;

            int newHours = totalTimeInMinutes / 60;
            int newMinutes = totalTimeInMinutes % 60;

            if (newHours > 23)
            {
                newHours = Math.Abs(24 - newHours);
            }

            Console.WriteLine($"{newHours}:{newMinutes:d2}");
        }
    }
}
