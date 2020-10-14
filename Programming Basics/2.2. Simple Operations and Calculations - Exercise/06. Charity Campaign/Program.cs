using System;

namespace _06._Charity_Campaign
{
    class Program
    {
        static void Main(string[] args)
        {
            double days = double.Parse(Console.ReadLine());
            double chefs = double.Parse(Console.ReadLine());
            double cake = double.Parse(Console.ReadLine());
            double waffles = double.Parse(Console.ReadLine());
            double pancakes = double.Parse(Console.ReadLine());

            double cakePrice = cake * 45.00;
            double wafflePrice = waffles * 5.80;
            double pancakePrice = pancakes * 3.2;

            double totalPrice = (days * chefs * (cakePrice + wafflePrice + pancakePrice));

            double totalNetPrice = totalPrice - (totalPrice / 8);

            Console.WriteLine($"{totalNetPrice:F2}");




        }
    }
}
