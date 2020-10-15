using System;

namespace _07._Flower_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());
            double giftPrice = double.Parse(Console.ReadLine());

            double allSold = (A * 3.25 + B * 4 + C * 3.5 + D * 8) * 0.95;

            if (allSold >= giftPrice)
            {
                double left = allSold - giftPrice;
                Console.WriteLine($"She is left with {Math.Floor(left)} leva.");
            }
            else
            {
                double borrow = giftPrice - allSold;
                Console.WriteLine($"She will have to borrow {Math.Ceiling(borrow)} leva.");
            }

        }
    }
}
