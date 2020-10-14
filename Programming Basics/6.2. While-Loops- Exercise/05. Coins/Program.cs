using System;

namespace _05._Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double change = double.Parse(Console.ReadLine());
            double coinsInCents = change * 100;
            int coinsCount = 0;

            while (coinsInCents >= 1)
            {
                coinsCount++;
                    if (coinsInCents >= 200)
                {
                    coinsInCents -= 200;
                }
                    else if (coinsInCents >= 100)
                {
                    coinsInCents -= 100;
                }
                else if (coinsInCents >= 50)
                {
                    coinsInCents -= 50;
                }
                else if (coinsInCents >= 20)
                {
                    coinsInCents -= 20;
                }
                else if (coinsInCents >= 10)
                {
                    coinsInCents -= 10;
                }
                else if (coinsInCents >= 5)
                {
                    coinsInCents -= 5;
                }
                else if (coinsInCents >= 2)
                {
                    coinsInCents -= 2;
                }
                else if (coinsInCents >= 1)
                {
                    coinsInCents -= 1;
                }
            }
            Console.WriteLine(coinsCount);
        }
    }
}
