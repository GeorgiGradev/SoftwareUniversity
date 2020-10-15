using System;

namespace _02._Bike_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            int juniors = int.Parse(Console.ReadLine());
            int seniors = int.Parse(Console.ReadLine());
            string trace = Console.ReadLine();

            double income = 0;
            switch (trace)
            {
                case "trail":
                    income = (juniors * 5.50) + (seniors * 7);
                    break;
                case "cross-country":
                        if (juniors + seniors >= 50)
                    { 
                        income = ((juniors * 8) + (seniors * 9.50)) * 0.75;
                    }
                    else
                    {
                        income = (juniors * 8) + (seniors * 9.50);
                    }
                    break;
                case "downhill":
                    income = (juniors * 12.25) + (seniors * 13.75);
                    break;
                case "road":
                    income = (juniors * 20) + (seniors * 21.50);
                    break;
            }
            double total = income * 0.95;
            Console.WriteLine($"{total:F2}");
        }
    }
}
