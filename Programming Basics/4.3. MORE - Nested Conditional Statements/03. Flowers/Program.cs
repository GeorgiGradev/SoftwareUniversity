using System;

namespace _03._Flowers
{
    class Program
    {
        static void Main(string[] args)
        {




            int chrys = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int tulips = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string holiday = Console.ReadLine();

            double totalPrice = 0;
            double totalFlowers = chrys + roses + tulips;

            if (season == "Spring" || season == "Summer")
            {
                double chrysPrice = 2.00 * chrys;
                double rosesPrice = 4.10 * roses;
                double tulipPrice = 2.50 * tulips;

                if (holiday == "Y")
                {
                    totalPrice = (chrysPrice + rosesPrice + tulipPrice) * 1.15;
                }
                else
                {
                    totalPrice = chrysPrice + rosesPrice + tulipPrice;
                }
                if (tulips > 7 && season == "Spring")
                {
                    totalPrice *= 0.95;
                }
            }

            else
            {
                double chrysPrice = 3.75 * chrys;
                double rosesPrice = 4.50 * roses;
                double tulipPrice = 4.15 * tulips;

                if (holiday == "Y")
                {
                    totalPrice = (chrysPrice + rosesPrice + tulipPrice) * 1.15;
                }
                else
                {
                    totalPrice = (chrysPrice + rosesPrice + tulipPrice);
                }

                if (roses >= 10 && season == "Winter")
                {
                    totalPrice *= 0.90;
                }
            }
            if (totalFlowers > 20)
            {
                totalPrice *= 0.80;
            }

                totalPrice += 2;

                Console.WriteLine($"{totalPrice:F2}");

        }
    }
}
