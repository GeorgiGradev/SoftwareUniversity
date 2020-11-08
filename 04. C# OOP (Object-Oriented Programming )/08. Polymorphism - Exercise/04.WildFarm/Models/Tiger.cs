using _04.WildFarm.Foods;
using System;
using System.Collections.Generic;

namespace _04.WildFarm.Models
{
    public class Tiger : Feline
    {
        private const double WEIGHT_MULTIPLIER = 1.00;
        public Tiger(string name, double weight, string livingRegion, string bread)
            : base(name, weight, livingRegion, bread)
        {

        }

        public override double WeightMultipplier => WEIGHT_MULTIPLIER;
        public override ICollection<Type> PrefferedFoods => new List<Type>() { typeof(Meat) };

        public override string ProduceSound()
        {
            return $"ROAR!!!";
        }
    }
}
