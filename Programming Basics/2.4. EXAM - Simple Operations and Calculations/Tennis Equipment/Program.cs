using System;

namespace _01._Tennis_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double tennisPrice = double.Parse(Console.ReadLine());
            int tennisNumber = int.Parse(Console.ReadLine());
            int shoesNumber = int.Parse(Console.ReadLine());

            double shoesPrice = tennisPrice / 6 * 1.0;

            double total = (tennisNumber * tennisPrice *1.0) + (shoesNumber * shoesPrice);
            double equipment = total * 0.2;

            double finalTotal = total + equipment;

            double djokPaid = finalTotal / 8;
            double sponsPaid = finalTotal * 7 / 8;

            Console.WriteLine("Price to be paid by Djokovic " + Math.Floor(djokPaid));
            Console.WriteLine("Price to be paid by sponsors " + Math.Ceiling(sponsPaid));


        }
    }
}
