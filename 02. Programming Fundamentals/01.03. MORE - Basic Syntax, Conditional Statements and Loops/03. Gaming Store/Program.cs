using System;

namespace _03._Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double budgetCopy = budget;
            string gameCommand = Console.ReadLine();
            double previousBudget = 0;
            bool isMoney = true;
            bool isFound = true;

            while (gameCommand != "Game Time")
            {
                previousBudget = budget;
                if (gameCommand == "OutFall 4")
                {
                    budget -= 39.99;
                }
                else if (gameCommand == "CS: OG")
                {
                    budget -= 15.99;
                }
                else if (gameCommand == "Zplinter Zell")
                {
                    budget -= 19.99;
                }
                else if (gameCommand == "Honored 2")
                {
                    budget -= 59.99;
                }
                else if (gameCommand == "RoverWatch")
                {
                    budget -= 29.99;
                }
                else if (gameCommand == "RoverWatch Origins Edition")
                {
                    budget -= 39.99;
                }
                else
                {
                    Console.WriteLine("Not Found");
                    isFound = false;
                }
                if (budget == 0)
                {
                    Console.WriteLine($"Bought {gameCommand}");
                    Console.WriteLine("Out of money!");
                    isMoney = false;
                    break;
                }
                if (budget < 0)
                {
                    Console.WriteLine("Too Expensive");
                    budget = previousBudget;
                }
                else if (budget > 0 && isFound)
                {
                    Console.WriteLine($"Bought {gameCommand}");
                }
                gameCommand = Console.ReadLine();
            }
            if (isMoney)
            {
                Console.WriteLine($"Total spent: ${budgetCopy - budget:f2}. Remaining: ${budget:f2}");
            }
        }
    }
}
