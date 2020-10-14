using System;

namespace _04._Money
{
    class Program
    {
        static void Main(string[] args)
        {
            int bitcoins = int.Parse(Console.ReadLine());
            double iuans = double.Parse(Console.ReadLine());
            double commission = double.Parse(Console.ReadLine());

            double bitcoinBGN = bitcoins * 1168;
            double iuanBGN = iuans * 0.15 * 1.76;

            double total = (bitcoinBGN + iuanBGN) / 1.95;
            Console.WriteLine(total - (total / 100 * commission));

        }
    }
}
