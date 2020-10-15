using System;

namespace _04._While_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingPaxNumber = int.Parse(Console.ReadLine());
            int busStopsNumber = int.Parse(Console.ReadLine());
            int totalPaxNumber = 0;
            int counter = 0;

            while (counter < busStopsNumber)
            {
                int leavingPax = int.Parse(Console.ReadLine());
                int comingPax = int.Parse(Console.ReadLine());

                counter++;
                if (counter % 2 != 0)
                {
                    totalPaxNumber += 2;
                }
                else if (counter % 2 == 0)
                {
                    totalPaxNumber -= 2;
                }
                totalPaxNumber += comingPax - leavingPax;

            }
            Console.WriteLine($"The final number of passengers is : {totalPaxNumber + startingPaxNumber}");
        }
    }
}