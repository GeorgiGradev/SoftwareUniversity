using _04.WildFarm.Foods;
using System;
using System.Collections.Generic;

namespace _04.WildFarm.Models
{
    public class Cat : Feline
    {
        private const double WEIGHT_MULTIPLIER = 0.30;
        public Cat(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed)
        {

        }

        public override double WeightMultipplier => WEIGHT_MULTIPLIER;

        public override ICollection<Type> PrefferedFoods => new List<Type>() { typeof(Meat), typeof(Vegetable) }; 

        public override string ProduceSound()
        {
            return $"Meow";
        }
    }
}
