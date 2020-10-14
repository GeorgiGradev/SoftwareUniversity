using System;

namespace _01._Easter_Bakery
{
    class Program
    {
        static void Main(string[] args)
        {
            double flourBgn = double.Parse(Console.ReadLine());
            double flourKg = double.Parse(Console.ReadLine());
            double sugarKg = double.Parse(Console.ReadLine());
            int eggBox = int.Parse(Console.ReadLine());
            int yeastPack = int.Parse(Console.ReadLine());

            double sugarBgn = flourBgn * 0.75;
            double eggBoxBgn = flourBgn * 1.1;
            double yeastPackBgn = sugarBgn * 0.20;

            double total = (flourBgn * flourKg) + (sugarBgn * sugarKg) + (eggBox * eggBoxBgn) + (yeastPack * yeastPackBgn);

            Console.WriteLine($"{total:F2}");


        }
    }
}
