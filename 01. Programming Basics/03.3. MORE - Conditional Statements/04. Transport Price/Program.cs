using System;

namespace _04._Transport_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            double kilometers = int.Parse(Console.ReadLine());
            string dayOrNight = Console.ReadLine();
            string day = "day";
            string night = "night";


            double taxiDay = 0.70 + (kilometers * 0.79);
            double taxiNight = 0.70 + (kilometers * 0.90);

            double bus = 0.09 * kilometers;

            double train = 0.06 * kilometers;
            
            if (kilometers < 20)
            {
                if (dayOrNight == day)
                {
                    Console.WriteLine($"{taxiDay:F2}");
                }
                else if (dayOrNight == night)
                {
                    Console.WriteLine($"{taxiNight:F2}");
                }
            }
            else if (kilometers < 100)
            {
                Console.WriteLine($"{bus:F2}");
            }
            else if (kilometers >= 100)
                Console.WriteLine($"{train:F2}");



        }
    }
}
