using System;

namespace _01._Simple_Operations_and_Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            double pens = double.Parse(Console.ReadLine());
            double markers = double.Parse(Console.ReadLine());
            double liters = double.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());

            double pricePens = pens * 5.8;
            double priceMarkers = markers * 7.2;
            double priceLiters = liters * 1.2;

            double price = priceLiters + priceMarkers + pricePens;
            double totalPrice = price - ((price * discount) / 100);

            Console.WriteLine($"{totalPrice:f3}");
        }
    }
}
