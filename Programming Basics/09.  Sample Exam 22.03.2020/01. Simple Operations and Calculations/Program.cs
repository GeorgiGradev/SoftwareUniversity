using System;

namespace _01._Simple_Operations_and_Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyForFood = double.Parse(Console.ReadLine());
            double moneyForSouveniers = double.Parse(Console.ReadLine());
            double moneyForHotel = double.Parse(Console.ReadLine());

            double hotelStay = (moneyForHotel * 0.90) + (moneyForHotel * 0.85) + (moneyForHotel * 0.80);
            double addCosts = 3 * (moneyForFood + moneyForSouveniers);

            double totalCost = 54.39 + hotelStay + addCosts;

            Console.WriteLine($"Money needed: {totalCost:f2}");
        }
    }
}
