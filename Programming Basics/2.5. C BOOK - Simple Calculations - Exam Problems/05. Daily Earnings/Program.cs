using System;

namespace _05._Daily_Earnings
{
    class Program
    {
        static void Main(string[] args)
        {
            int workingDays = int.Parse(Console.ReadLine());
            double earnedPerDay = double.Parse(Console.ReadLine());
            double usInBgn = double.Parse(Console.ReadLine());

            double yearIncome = (workingDays * earnedPerDay) * 12;
            double bonus = yearIncome / 12 * 2.5;
            double totalUSD = (yearIncome + bonus) * 0.75;
            double totalBGN = totalUSD * usInBgn;

            Console.WriteLine($"{totalBGN / 365:F2}");




        }
    }
}
