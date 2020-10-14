using System;

namespace _04._Vegetable_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double vegiBGN = double.Parse(Console.ReadLine());
            double fruitsBGN = double.Parse(Console.ReadLine());
            double vegiKG = double.Parse(Console.ReadLine());
            double fruitsKG = double.Parse(Console.ReadLine());

            double euro = 1.94;
            double vegi = vegiBGN * vegiKG;
            double fruits = fruitsBGN * fruitsKG;

            double total = (vegi + fruits) / euro;

            Console.WriteLine($"{total:F2}");
        }
    }
}
