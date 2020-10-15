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

            double p1 = p * 1.0;
            double h1 = h * 1.0;


            double SofiaPlayedDays = (48 - h1) * 3 / 4 + p1 * 2 / 3 ; 
            double allPlayedDays = SofiaPlayedDays + h1; 

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
