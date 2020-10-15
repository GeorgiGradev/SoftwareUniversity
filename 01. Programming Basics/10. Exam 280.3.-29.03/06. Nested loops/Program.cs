using System;

namespace _06._Nested_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            double days = double.Parse(Console.ReadLine());
            string sportCommand = "";

            double totalMoney = 0;
            double dayWinCounter = 0;
            double dayLoseCounter = 0;

            for (int i = 1; i <= days; i++)
            {
                sportCommand = Console.ReadLine();
                double winCounter = 0;
                double loseCounter = 0;
                double dayMoney = 0;
                while (sportCommand != "Finish")
                {
                    string result = Console.ReadLine();
                    if (result == "win")
                    {
                        dayMoney += 20;
                        winCounter++;
                    }
                    else if (result == "lose")
                    {
                        loseCounter++;
                    }
                    sportCommand = Console.ReadLine();
                }
                if (winCounter > loseCounter)
                {
                    dayMoney *= 1.1;
                    dayWinCounter++;
                }
                else
                {
                    dayLoseCounter++;
                }
                totalMoney += dayMoney;
            }
            if (dayWinCounter > dayLoseCounter)
            {
                totalMoney *= 1.2;
                Console.WriteLine($"You won the tournament! Total raised money: {totalMoney:f2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {totalMoney:f2}");
            }
        }
    }
}
