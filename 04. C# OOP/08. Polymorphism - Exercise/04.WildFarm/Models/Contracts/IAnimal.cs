using System;
using System.Collections.Generic;
using System.Text;

namespace _04.WildFarm.Models.Contracts
{
    public interface IAnimal
    {
        public string Name { get; }
        public double Weight { get; }
        public int FoodEaten { get; }

        string ProduceSound();
        void Feed(IFood food);
    }
}
