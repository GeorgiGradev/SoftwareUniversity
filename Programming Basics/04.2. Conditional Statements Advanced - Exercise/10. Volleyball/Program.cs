using System;

namespace _10._Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            int p = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
             


            double SofiaPlayedDays = ((48 - (h * 1.0)) * 3 / 4) + 2 / 3.0 * (p * 1.0); // 34.5 + 3.33 =  37.83
            double allPlayedDays = SofiaPlayedDays + h; // 37.83 + 2 = 39.83

            switch (year)
            {
                case "leap":
                    allPlayedDays *= 1.15;
                    Console.WriteLine($"{Math.Floor(allPlayedDays)}");
                    break;
                case "normal":
                    Console.WriteLine($"{Math.Floor(allPlayedDays)}");
                    break;
            }
        }
    }
}
