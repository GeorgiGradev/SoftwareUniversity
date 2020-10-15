using System;

namespace _07._Alcohol_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double whiskeyBGN = double.Parse(Console.ReadLine());
            double beerLtr = double.Parse(Console.ReadLine());
            double wineLtr = double.Parse(Console.ReadLine());
            double rakiyaLtr = double.Parse(Console.ReadLine());
            double whiskeyLtr = double.Parse(Console.ReadLine());

            double rakiyaBGN = whiskeyBGN / 2;
            double wineBGN = rakiyaBGN - (0.4 * rakiyaBGN);
            double beerBGN = rakiyaBGN - (0.8 * rakiyaBGN);
   
            double total = (whiskeyBGN * whiskeyLtr) + (rakiyaBGN * rakiyaLtr) + (wineBGN * wineLtr) + (beerBGN * beerLtr);
            Console.WriteLine($"{total:f2}");
        }
    }
}
