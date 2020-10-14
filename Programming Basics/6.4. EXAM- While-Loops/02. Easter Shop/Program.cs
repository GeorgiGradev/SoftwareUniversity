using System;

namespace _02._Easter_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int beginningEggs = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            int soldEggsCount = 0;
            int availableEggs = 0;

            while (command != "Close")
            {

                if (command == "Fill")
                {
                    int fill = int.Parse(Console.ReadLine());
                    beginningEggs += fill;
                }
                if (command == "Buy")
                {
                    int buy = int.Parse(Console.ReadLine());
                    beginningEggs -= buy;
                    if (beginningEggs < 0)
                    {
                        Console.WriteLine($"Not enough eggs in store!");
                        Console.WriteLine($"You can buy only {availableEggs}.");
                    }
                    else
                    {
                        soldEggsCount += buy;
                    }
                }
                availableEggs = beginningEggs;
                command = Console.ReadLine();
            }

            if (command == "Close")
            {
                Console.WriteLine("Store is closed!");
                Console.WriteLine($"{soldEggsCount} eggs sold.");
            }
        }
    }
}
