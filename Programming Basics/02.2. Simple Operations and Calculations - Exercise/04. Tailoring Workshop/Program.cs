using System;

namespace _04._Tailoring_Workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            int tables = int.Parse(Console.ReadLine());
            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double TableCloth1 = tables * (lenght + (2 * 0.3)) * (width + 2 * 0.3);
            double SquareCloth2 = tables * ((lenght / 2) * (lenght / 2));

            double price1 = TableCloth1 * 7;
            double price2 = SquareCloth2 * 9;
            double USD = 1.85;

            double totalpriceUSD = price1 + price2;



            Console.WriteLine("{0:f2} USD", totalpriceUSD);
            Console.WriteLine("{0:f2} BGN", totalpriceUSD * USD);
        }
    }
}
