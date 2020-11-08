using System;
using System.Collections.Generic;
using _04.WildFarm.Foods;

namespace _04.WildFarm.Models
{
    public class Hen : Bird
    {
        private const double WEIGHT_MULTIPLIER = 0.35;
        public Hen(string name, double weight, double wingSize )
            : base(name, weight, wingSize)
        {
          
        }

        public override double WeightMultipplier => WEIGHT_MULTIPLIER;

        public override ICollection<Type> PrefferedFoods => new List<Type>() { typeof(Vegetable), typeof(Fruit), typeof(Meat), typeof(Seeds) };

        public override string ProduceSound()
        {
            return $"Cluck";
        }
    }
}
