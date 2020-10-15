using System;

namespace _05._Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine());
            double minute1 = minute + 15;

            if (hour == 23 & minute >= 45)
            {
                minute1 = (minute + 15) - 60; 
                hour = 0;
                if (minute1 < 10)
                {
                    Console.WriteLine($"{hour}:0{minute1}");
                }
                else
                {
                    Console.WriteLine($"{hour}:{minute1}");
                }

            }
            else if (hour != 23 & minute >= 45)
            {
                minute1 = (minute + 15) % 60;
                hour += 1;
                if (minute1 < 10)
                {
                    Console.WriteLine($"{hour}:0{minute1}");
                }
                else
                {
                    Console.WriteLine($"{hour}:{minute1}");
                }
            }
            else 
            {
                minute1 = minute + 15;
                if (minute1 < 10)
                {
                    Console.WriteLine($"{hour}:0{minute1}");
                }
                else
                {
                    Console.WriteLine($"{hour}:{minute1}");
                }
            }
 

        }
    }
}
