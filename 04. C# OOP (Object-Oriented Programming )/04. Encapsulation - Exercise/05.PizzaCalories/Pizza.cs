using System;
using System.Collections.Generic;

namespace PizzaCalories
{
    public class Pizza
    {
        private string name;
        private Dough dough;
        private List<Topping> toppings;

        public Pizza(string name)
        {
            this.Name = name;
            this.toppings = new List<Topping>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Length < 1 || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }

                this.name = value;
            }
        }

        public Dough Dough
        {
            set
            {
                this.dough = value;
            }
        }

        public void AddTopping(Topping topping)
        {
            if (this.toppings.Count == 10)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }

            this.toppings.Add(topping);
        }

        private decimal CalculateCalories()
        {
            decimal totalCalories = 0;

            totalCalories += this.dough.GetTotalCalories;

            foreach (var topping in toppings)
            {
                totalCalories += topping.GetTotalCaloris;
            }

            return totalCalories;
        }

        public override string ToString()
        {
            return $"{this.Name} - {this.CalculateCalories():F2} Calories.";
        }
    }
}
