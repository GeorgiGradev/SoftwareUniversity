using _04.PizzaCalories.Common;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Transactions;

namespace _04.PizzaCalories.Models
{
    public class Dough
    {
        private string flourType;
        private string backingTechnique;
        private double weightGrams;

        private readonly Dictionary<string, double> flourTypeDict = new Dictionary<string, double>
        {
            {"white", 1.5 },
            {"wholegrain", 1.0 }
        };

        private readonly Dictionary<string, double> backingTechniqueDict = new Dictionary<string, double>
        {
            {"crispy", 0.9 },
            {"chewy", 1.1 },
            {"homemade", 1.0 }
        };

        public Dough(string flourType, string backingTechnique, double weightGrams)
        {
            this.FlourType = flourType;
            this.BackingTechnique = backingTechnique;
            this.WeightGrams = weightGrams;
        }


        public string FlourType
        {
            get 
            { 
                return flourType; 
            }
            private set 
            { 
                if (!flourTypeDict.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }   
                flourType = value;
            }
        }

        public string BackingTechnique
        {
            get 
            { 
                return backingTechnique; 
            }
            private set
            {
                if (!backingTechniqueDict.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                backingTechnique = value; 
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
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range[1..200].");
                }
                this.weightGrams = value;
            }
        }




        public string TotalCalories()
        {
            double result = GlobalConstants.caloriesPerGram * this.weightGrams * this.flourTypeDict[flourType] * backingTechniqueDict[this.backingTechnique];

            return result.ToString();

        }

    }
}
