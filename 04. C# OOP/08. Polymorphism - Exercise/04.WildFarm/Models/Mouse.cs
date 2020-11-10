using _04.WildFarm.Foods;
using System;
using System.Collections.Generic;

namespace _04.WildFarm.Models
{
    public class Mouse : Mammal
    {
        private const double WEIGHT_MULTIPLIER = 0.10;
        public Mouse(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion)
        {
        }
        public override double WeightMultipplier => WEIGHT_MULTIPLIER;

        public override ICollection<Type> PrefferedFoods => new List<Type>() { typeof(Fruit), typeof(Vegetable)};

        public override string ProduceSound()
        {
            return $"Squeak";
        }
    }
}
