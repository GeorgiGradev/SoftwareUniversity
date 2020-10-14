using System;

namespace _06._Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            double mackerelPrice = double.Parse(Console.ReadLine());
            double spratPrice = double.Parse(Console.ReadLine());
            double beltedBonitoKG = double.Parse(Console.ReadLine());
            double scadKG = double.Parse(Console.ReadLine());
            double musselsKG = double.Parse(Console.ReadLine());

            double beltedBonitoPrice = mackerelPrice * 1.6 * beltedBonitoKG;
            double scadPrice = spratPrice  * 1.80 * scadKG;
            double musselsPrice = 7.50 * musselsKG;

            double total = beltedBonitoPrice + scadPrice + musselsPrice;

            Console.WriteLine($"{total:F2}");





        }
    }
}
