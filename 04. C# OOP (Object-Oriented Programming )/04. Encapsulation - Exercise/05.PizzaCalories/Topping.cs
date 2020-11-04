using System;

namespace PizzaCalories
{
    public class Topping
    {
        private const decimal Meat = 1.2m;
        private const decimal Veggies = 0.8m;
        private const decimal Cheese = 1.1m;
        private const decimal Sauce = 0.9m;

        private string type;
        private decimal grams;

        public Topping(string type, decimal grams)
        {
            this.Type = type;
            this.Grams = grams;
        }

        private string Type
        {
            get
            {
                return this.type;
            }
            set
            {
                if (value.ToLower() != "meat" &&
                    value.ToLower() != "veggies" &&
                    value.ToLower() != "cheese" &&
                    value.ToLower() != "sauce")
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }

                this.type = value;
            }
        }

        private decimal Grams
        {
            get
            {
                return this.grams;
            }
            set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException($"{this.Type} weight should be in the range [1..50].");
                }

                this.grams = value;
            }
        }

        public decimal GetTotalCaloris
        {
            get
            {
                return this.CalculateCalories();
            }
        }

        private decimal CalculateCalories()
        {
            return 2 * this.Grams * this.Modifier();
        }

        private decimal Modifier()
        {
            decimal typeModifier = 0;

            if (this.Type.ToLower() == "meat")
            {
                typeModifier = Meat;
            }
            else if (this.Type.ToLower() == "veggies")
            {
                typeModifier = Veggies;
            }
            else if (this.Type.ToLower() == "cheese")
            {
                typeModifier = Cheese;
            }
            else if (this.Type.ToLower() == "sauce")
            {
                typeModifier = Sauce;
            }

            return typeModifier;
        }
    }
}
