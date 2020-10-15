using System;

namespace _05._Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int hoursNeeded = int.Parse(Console.ReadLine());
            int daysPresent = int.Parse(Console.ReadLine());
            int extraWorkers = int.Parse(Console.ReadLine());

            double hoursPresent = (8 * daysPresent * 0.9);

            double extraWork = extraWorkers * 2 * daysPresent;
            double total = Math.Floor(hoursPresent + extraWork);

        

           if (hoursNeeded <= total)
            {
                Console.WriteLine($"Yes!{total - hoursNeeded} hours left.");
            }

           else
            {
                Console.WriteLine($"Not enough time!{hoursNeeded - total} hours needed.");
            }
        }
    }
}
