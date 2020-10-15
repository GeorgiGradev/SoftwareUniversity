using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace _09.PokemonTrainer
{
    public class Pokemon
    {
        private string pokemonElement;
        private int pokemonHealth;

        public Pokemon(string pokemonElement, int pokemonHealth)
        {
            this.PokemonElement = pokemonElement;
            this.PokemonHealth = pokemonHealth;
        }
        public string PokemonElement { get; set; }
        public int PokemonHealth { get; set; }
    }
}
