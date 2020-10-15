using System;

namespace _05._For_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int budgetSinger = int.Parse(Console.ReadLine());
            string paxNumberCommand = Console.ReadLine();
            int income = 0;
            int counter = 0;

            while (paxNumberCommand != "The restaurant is full")
            {
                int paxNumber = int.Parse(paxNumberCommand);
                if (paxNumber < 5)
                {
                    income += (paxNumber * 100);
                    counter += paxNumber;
                }
                else
                {
                    income += (paxNumber * 70);
                    counter += paxNumber;
                }
                paxNumberCommand = Console.ReadLine();
            }
            int diff = income - budgetSinger;
            if (income >= budgetSinger)
            {
                Console.WriteLine($"You have {counter} guests and {diff} leva left.");
            }
            else
            {
                Console.WriteLine($"You have {counter} guests and {income} leva income, but no singer.");
            }
        }
    }
}
