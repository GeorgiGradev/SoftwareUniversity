using System;

namespace _02._Vegetable_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double vegiBGN = double.Parse(Console.ReadLine());
            double fruitsBGN = double.Parse(Console.ReadLine());
            double vegiKG = double.Parse(Console.ReadLine());
            double fruitsKG = double.Parse(Console.ReadLine());

            double total = ((vegiBGN * vegiKG) + (fruitsBGN * fruitsKG)) / 1.94;

            Console.WriteLine($"{total}");

        }
    }
}
