using System;
using System.Linq;
using System.Collections.Generic;

namespace SummerCocktails
{
    class StartUp
    {
        static void Main()
        {
            int[] inputIngredient = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] inputFreshnessLevel = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();


            Queue<int> ingredient = new Queue<int>(inputIngredient);
            Stack<int> freshnessLevel = new Stack<int>(inputFreshnessLevel);
            Dictionary<string, int> cocktails = new Dictionary<string, int>()
            {
                { "Mimosa" , 0 },
                { "Daiquiri" , 0 },
                { "Sunshine" , 0 },
                { "Mojito" , 0 }
            };

            while (ingredient.Any() && freshnessLevel.Any())
            {
                var currentIngredient = ingredient.Peek();
                var currentFreshnessLevel = freshnessLevel.Peek();

                if (currentIngredient == 0)
                {
                    ingredient.Dequeue();
                    continue;
                }

                if (currentIngredient * currentFreshnessLevel == 150) //Mimosa
                {
                    cocktails["Mimosa"]++;
                    ingredient.Dequeue();
                    freshnessLevel.Pop();
                }
                else if (currentIngredient * currentFreshnessLevel == 250) //Daiquiri
                {
                    cocktails["Daiquiri"]++;
                    ingredient.Dequeue();
                    freshnessLevel.Pop();
                }
                else if (currentIngredient * currentFreshnessLevel == 300) // Sunshine
                {
                    cocktails["Sunshine"]++;
                    ingredient.Dequeue();
                    freshnessLevel.Pop();
                }
                else if (currentIngredient * currentFreshnessLevel == 400) //Mojito
                {
                    cocktails["Mojito"]++;
                    ingredient.Dequeue();
                    freshnessLevel.Pop();
                }
                else
                {
                    freshnessLevel.Pop();
                    ingredient.Enqueue(ingredient.Dequeue() + 5);
                }
            }

            bool areCocktailsReady = true;

            foreach (var cocktail in cocktails)
            {
                if (cocktail.Value == 0)
                {
                    areCocktailsReady = false;
                    break;
                }
            }

            Dictionary<string, int> readyCocktails = cocktails
                .Where(x => x.Value != 0)
                .ToDictionary(a => a.Key, b => b.Value);

            if (areCocktailsReady)
            {
                Console.WriteLine("It's party time! The cocktails are ready!");

                PrintIngredientSumIfAny(ingredient);
                PrintCocktails(readyCocktails);
            }
            else
            {
                Console.WriteLine("What a pity! You didn't manage to prepare all cocktails.");

                PrintIngredientSumIfAny(ingredient);
                PrintCocktails(readyCocktails);
            }
        }

        private static void PrintCocktails(Dictionary<string, int> readyCocktails)
        {
            foreach (var cocktail in readyCocktails.OrderBy(x => x.Key))
            {
                Console.WriteLine($" # {cocktail.Key} --> {cocktail.Value}");
            }
        }

        private static void PrintIngredientSumIfAny(Queue<int> ingredient)
        {
            if (ingredient.Any())
            {
                Console.WriteLine($"Ingredients left: {ingredient.Sum()}");
            }
        }
    }
}