using _04.WildFarm.Common;
using _04.WildFarm.Models.Contracts;
using System;
using System.Collections.Generic;

namespace _04.WildFarm.Models
{
    public abstract class Animal : IAnimal
    {
        private const string UneatableFoodMessage = "{0} does not eat {1}!";

        protected Animal(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }

        public string Name { get; private set; }
        public double Weight { get; private set; }
        public int FoodEaten { get; private set; }

        public abstract double WeightMultipplier {get; }
        public abstract ICollection<Type> PrefferedFoods { get;  }

        public void Feed(IFood food)
        {
            if (!this.PrefferedFoods.Contains(food.GetType()))
            {
                throw new UneatableFoodException(string.Format(UneatableFoodMessage, this.GetType().Name, food.GetType().Name));
            }

            this.Weight += this.WeightMultipplier * food.Quantity;
            this.FoodEaten += food.Quantity;
        }

        public abstract string ProduceSound();
    }
}
