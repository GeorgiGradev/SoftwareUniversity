using System;

namespace _03._Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            double sqMeters = double.Parse(Console.ReadLine());
            double grapesM2 = double.Parse(Console.ReadLine());
            double wineForSale = double.Parse(Console.ReadLine());
            double workers = double.Parse(Console.ReadLine());

            double harvest = sqMeters * grapesM2 * 0.4;
            double wine = harvest / 2.5;

            double result = Math.Abs(wine - wineForSale);

            if (wine >= wineForSale)
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wine)} liters.");
                double wineForWorker = result / workers;
                Console.WriteLine($"{Math.Ceiling(result)} liters left -> {Math.Ceiling(wineForWorker)} liters per person.");
            }
            else if (wine < wineForSale)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(result)} liters wine needed.");
            }

        }
    }
}
