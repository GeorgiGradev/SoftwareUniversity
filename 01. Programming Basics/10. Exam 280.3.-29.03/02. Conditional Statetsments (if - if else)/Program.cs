using System;

namespace _02._Conditional_Statetsments__if___if_else_
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timeFor1meter = double.Parse(Console.ReadLine());

            double averageTime = distance * timeFor1meter;
            double delay = (Math.Floor(distance / 50)) * 30;
            double totalTime = averageTime + delay;

            if (totalTime < record)
            {
                Console.WriteLine($"Yes! The new record is {totalTime:f2} seconds.");
            }
            else
            {
                double diff = totalTime - record;
                Console.WriteLine($"No! He was {diff:f2} seconds slower.");
            }
        }
    }
}
