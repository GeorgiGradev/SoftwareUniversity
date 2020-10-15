using System;

namespace _01._Disneyland_Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double savedMoney = 0;

            for (int i = 1; i <= months; i++)
            {
                if (i != 1 && i % 2 != 0)
                {
                    savedMoney -= savedMoney * 0.16;
                }
                if (i % 4 == 0)
                {
                    savedMoney += savedMoney * 0.25;
                }
                savedMoney += neededMoney * 0.25;
            }
            if (savedMoney >= neededMoney)
            {
                double moneyForSouvenirs = savedMoney - neededMoney;
                Console.WriteLine($"Bravo! You can go to Disneyland and you will have {moneyForSouvenirs:f2}lv. for souvenirs.");
            }
            else if (neededMoney > savedMoney)
            {
                double missing = neededMoney - savedMoney;
                Console.WriteLine($"Sorry. You need {missing:f2}lv. more.");
            }
        }
    }
}
