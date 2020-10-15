using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double ownedMoney = double.Parse(Console.ReadLine());
            int countDays = 0;
            int countSpendDays = 0;

            while (ownedMoney < neededMoney)
            {
                string action = Console.ReadLine();
                double inORout = double.Parse(Console.ReadLine());
                countDays++;
                if (action == "save")
                {
                    ownedMoney += inORout;
                    countSpendDays = 0;
                }
                else if (action == "spend")
                {  
                    ownedMoney -= inORout;
                    countSpendDays++;
                    if (ownedMoney < 0)
                    {
                        ownedMoney = 0;
                    }
                }
                if (countSpendDays == 5)
                {
                    break;
                }
            }
            if (ownedMoney >= neededMoney && countSpendDays < 5)
            {
                Console.WriteLine($"You saved the money for {countDays} days.");
            }
            if (countSpendDays == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(countDays);
            }
        }
    }
}
