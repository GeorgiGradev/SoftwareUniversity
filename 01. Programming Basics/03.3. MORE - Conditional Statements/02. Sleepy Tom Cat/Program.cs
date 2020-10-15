using System;

namespace _02._Sleepy_Tom_Cat
{
    class Program
    {
        static void Main(string[] args)
        {
            int vacationDays = int.Parse(Console.ReadLine());
            int workingDays = 365 - vacationDays;

            int playWorkingDays = 63 * workingDays;
            int playVacationDays = 127 * vacationDays;
            int totalPlay = playVacationDays + playWorkingDays;

            int lastResult = Math.Abs(30000 - totalPlay);

            int hours = lastResult / 60;
            int minutes = lastResult % 60;

            if (totalPlay >= 30000)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hours} hours and {minutes} minutes more for play");
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hours} hours and {minutes} minutes less for play");
            }
        }
    }
}
