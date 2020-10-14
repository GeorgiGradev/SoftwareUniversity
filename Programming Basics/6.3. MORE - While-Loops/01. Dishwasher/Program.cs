using System;

namespace _01._Dishwasher
{
    class Program
    {
        static void Main(string[] args)
        {
            int bottles = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            int bottlesInML = bottles * 750;
            int counterTotal = 0;
            int counterDishes = 0;
            int counterPots = 0;

            while (command != "End")
            {
                int commandAsNumber = int.Parse(command);

                counterTotal++;
                if (counterTotal % 3 != 0)
                {
                    counterDishes += commandAsNumber;
                    bottlesInML -= (commandAsNumber * 5);
                }
                else
                {
                    counterPots += commandAsNumber;
                    bottlesInML -= (commandAsNumber * 15);
                }
                if (bottlesInML < 0)
                {
                    Console.WriteLine($"Not enough detergent, {Math.Abs(bottlesInML)} ml. more necessary!");
                    break;
                }

                command = Console.ReadLine();
            }

            if (command == "End")
            {
                Console.WriteLine("Detergent was enough!");
                Console.WriteLine($"{counterDishes} dishes and {counterPots} pots were washed.");
                Console.WriteLine($"Leftover detergent {bottlesInML} ml.");
            }

        }
    }
}