using System;

namespace _10._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            double sum = 0;
            int counter = 0;

            for (int i = 1; i <= lostGamesCount; i++)
            {
                if (i % 2 == 0)
                {
                    sum += headsetPrice;
                }
                if (i % 3 == 0)
                {
                    sum += mousePrice;
                }
                if (i % 2 == 0 && i % 3 == 0)
                {
                    sum += keyboardPrice;
                    counter++;
                }
                if (counter != 0 && counter == 2)
                {
                    sum += displayPrice;
                    counter = 0;
                }
            }
            Console.WriteLine($"Rage expenses: {sum:f2} lv.");
        }
    }
}
