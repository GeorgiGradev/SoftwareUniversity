using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.PokemonTrainer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            string trainerName = string.Empty;
            int numberOfBadges = 0;
            string pokemonElement = string.Empty;
            int pokemonHealth = 0;

            Pokemon pokemon = new Pokemon(pokemonElement, pokemonHealth);

            List<Pokemon> collectionOfPokemons = new List<Pokemon>();
            Trainer trainer = new Trainer(numberOfBadges, collectionOfPokemons);

            Dictionary<string, Trainer> dict = new Dictionary<string, Trainer>();

            while ((input = Console.ReadLine()) != "Tournament")
            {
                string[] tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                trainerName = tokens[0];
                pokemonElement = tokens[2];
                pokemonHealth = int.Parse(tokens[3]);
                pokemon = new Pokemon(pokemonElement, pokemonHealth);

                if (!dict.ContainsKey(trainerName))
                {
                    dict.Add(trainerName, new Trainer(numberOfBadges, new List<Pokemon>()));
                }
                dict[trainerName].CollectionOfPokemons.Add(pokemon);
            }

            while ((input = Console.ReadLine()) != "End")
            {
                foreach (var item in dict)
                {
                    var trainerToCheck = item.Value;
                    if (trainerToCheck.CollectionOfPokemons.Any(p => p.PokemonElement == input))
                    {
                        trainerToCheck.NumberOfBadges++;
                    }
                    else
                    {
                        for (int i = 0; i < trainerToCheck.CollectionOfPokemons.Count; i++)
                        {
                            var pokemonToCheck = trainerToCheck.CollectionOfPokemons[i];
                            if (pokemonToCheck.PokemonHealth > 10)
                            {
                                pokemonToCheck.PokemonHealth -= 10;
                            }
                            else
                            {
                                trainerToCheck.CollectionOfPokemons.Remove(pokemonToCheck);
                                i--;
                            }
                        }
                    }
                }
            }
            foreach (var item in dict.OrderByDescending(x =>x.Value.NumberOfBadges))
            {
                Console.WriteLine($"{item.Key} {item.Value.NumberOfBadges} {item.Value.CollectionOfPokemons.Count}");
            }
        }
    }
}
