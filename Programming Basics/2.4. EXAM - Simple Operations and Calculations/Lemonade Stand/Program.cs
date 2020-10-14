using System;

namespace _01._Lemonade_Stand
{
    class Program
    {
        static void Main(string[] args)
        {
            double lemonKG = double.Parse(Console.ReadLine());
            double sugarKG = double.Parse(Console.ReadLine());
            double waterLTR = double.Parse(Console.ReadLine());

            double LemonJuice = lemonKG * 980;
            double liquid = LemonJuice + (waterLTR * 1000) + (sugarKG * 0.3);
            double cups = Math.Floor(liquid / 150);
            double earned = cups * 1.2;


            Console.WriteLine($"All cups sold: {cups}");
            Console.WriteLine($"Money earned: {earned:F2}");

        }
    }
}
