using System;

namespace _02._01._Easter_Party
{
    class Program
    {
        static void Main(string[] args)
        {

            // Между 10 (вкл.) и 15(вкл.) човека-> 15 % отстъпка от куверта за един човек
            // Между 15 и 20(вкл.) човека-> 20 % отстъпка от куверта за един човек
            // Над 20 човека-> 25 % отстъпка от куверта за един човек

            // > 21 pax -> 25 % discount
            // > 16 pax -> 20 % discount
            // > 10 pax -> 15 % discount

            // cake price = 10 % from the budget

            int pax = int.Parse(Console.ReadLine());
            double cover = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double cakePrice = budget * 0.1;

            if (pax >= 21)
            {
                double coverPrice = cover * pax * 0.75 + cakePrice;
                if (budget >= coverPrice)
                {
                    double leftOver = budget - coverPrice;
                    Console.WriteLine($"It is party time! {leftOver:F2} leva left.");
                }
                else
                {
                    double missing = coverPrice - budget;
                    Console.WriteLine($"No party! {missing:F2} leva needed.");
                }
             }
            else if (pax >= 16)
            {
                double coverPrice = cover * pax * 0.80 + cakePrice;
                if (budget >= coverPrice)
                {
                    double leftOver = budget - coverPrice;
                    Console.WriteLine($"It is party time! {leftOver:F2} leva left.");
                }
                else
                {
                    double missing = coverPrice - budget;
                    Console.WriteLine($"No party! {missing:F2} leva needed.");
                }
            }
            else if (pax >= 10)
            {
                double coverPrice = cover * pax * 0.85 + cakePrice;
                if (budget >= coverPrice)
                {
                    double leftOver = budget - coverPrice;
                    Console.WriteLine($"It is party time! {leftOver:F2} leva left.");
                }
                else
                {
                    double missing = coverPrice - budget;
                    Console.WriteLine($"No party! {missing:F2} leva needed.");
                }
            }
            else
            {
                double coverPrice = cover * pax + cakePrice;
                if (budget >= coverPrice)
                {
                    double leftOver = budget - coverPrice;
                    Console.WriteLine($"It is party time! {leftOver:F2} leva left.");
                }
                else
                {
                    double missing = coverPrice - budget;
                    Console.WriteLine($"No party! {missing:F2} leva needed.");
                }
            }
        }
    }
}
