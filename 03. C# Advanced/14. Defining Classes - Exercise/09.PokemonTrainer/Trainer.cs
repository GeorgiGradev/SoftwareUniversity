using System;
using System.Collections.Generic;
using System.Text;

namespace _09.PokemonTrainer
{
    public class Trainer
    {
        private int numberOfBadges;
        private List<Pokemon> collectionOfPokemons;


        public Trainer(int numberOfBadges, List<Pokemon> collectionOfPokemons)
        {
            this.NumberOfBadges = numberOfBadges;
            this.CollectionOfPokemons = collectionOfPokemons;
        }


        public int NumberOfBadges { get; set; }
        public List<Pokemon> CollectionOfPokemons { get; set; }

    }
}
