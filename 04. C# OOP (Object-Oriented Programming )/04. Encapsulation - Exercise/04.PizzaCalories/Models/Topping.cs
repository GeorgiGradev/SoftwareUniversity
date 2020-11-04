using _04.PizzaCalories.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace _04.PizzaCalories.Models
{
    public class Topping
    {
        private string toppingName;
        private double weightGrams;

        private readonly Dictionary<string, double> toppingDict = new Dictionary<string, double>
        {
            {"meat", 1.2 },
            {"veggies", 0.8 },
            {"cheese", 1.1 },
            {"sauce", 1.1 }
        };

        public Topping(string toppingName, double weightGrams)
        {
            this.ToppingName = toppingName;
            this.WeightGrams = weightGrams;
        }

        public string ToppingName
        {
            get
            {
                return this.toppingName;
            }
            set
            {
                if (!toppingDict.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                this.toppingName = value;
            }
        }


        public double WeightGrams
        {
            get
            {
                return this.weightGrams;
            }
            set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException($"{this.toppingName} weight should be in the range [1..50].");
                }
                this.weightGrams = value;
            }
        
        }

        public string TotalCalories()
        {
            double result =  GlobalConstants.caloriesPerGram * this.weightGrams * this.toppingDict[this.toppingName];
            return result.ToString();
        }

    }
}
