using System;
using System.Linq;
using System.Collections.Generic;

namespace SpaceshipCrafting
{
    public class StartUp
    {
        public static void Main()
        {
            int[] inputLiquids = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] inputItems = Console.ReadLine()
               .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();

            Queue<int> liquids = new Queue<int>(inputLiquids);
            Stack<int> items = new Stack<int>(inputItems);

            Dictionary<string, int> spaceshipItems = new Dictionary<string, int>()
            {
                { "Aluminium", 0},
                { "Carbon fiber", 0},
                { "Glass", 0},
                { "Lithium", 0}
            };

            while (liquids.Any() && items.Any())
            {
                int currentLiquid = liquids.Peek();
                int currentItem = items.Peek();

                if (currentLiquid + currentItem == 50)
                {
                    spaceshipItems["Aluminium"]++;
                    liquids.Dequeue();
                    items.Pop();
                }
                else if (currentLiquid + currentItem == 100)
                {
                    spaceshipItems["Carbon fiber"]++;
                    liquids.Dequeue();
                    items.Pop();
                }
                else if (currentLiquid + currentItem == 25)
                {
                    spaceshipItems["Glass"]++;
                    liquids.Dequeue();
                    items.Pop();
                }
                else if (currentLiquid + currentItem == 75)
                {
                    spaceshipItems["Lithium"]++;
                    liquids.Dequeue();
                    items.Pop();
                }
                else
                {
                    liquids.Dequeue();
                    items.Push(items.Pop() + 3);
                }

            }

            bool isBuildingSucceeded = true;

            foreach (var item in spaceshipItems)
            {
                if (item.Value == 0)
                {
                    isBuildingSucceeded = false;
                    break;
                }
            }

            string message = isBuildingSucceeded
                ? "Wohoo! You succeeded in building the spaceship!"
                : "Ugh, what a pity! You didn't have enough materials to build the spaceship.";

            Console.WriteLine(message);

            string matchedLiquids = liquids.Any()
                ? string.Join(", ", liquids)
                : "none";

            Console.WriteLine($"Liquids left: {matchedLiquids}");

            string matchedItems = items.Any()
                ? string.Join(", ", items)
                : "none";
            Console.WriteLine($"Physical items left: {matchedItems}");

            foreach (var item in spaceshipItems)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}