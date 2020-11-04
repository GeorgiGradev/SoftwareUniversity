using System;

namespace PizzaCalories
{
    public class Dough
    {
        private const decimal BASE_CALORIES_PER_GRAM = 2;
        private const string INVALID_DOUGH_MESSAGE = "Invalid type of dough.";

        private const decimal WhiteFlour = 1.5m;
        private const decimal WholegrainFlour = 1m;

        private const decimal CrispyTechnique = 0.9m;
        private const decimal ChewyTechnique = 1.1m;
        private const decimal HomemadeTechnique = 1m;

        private decimal weight;
        private string flourType;
        private string bakingTechnique;

        public Dough(string flourType, string bakingTechnique, decimal weight)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
        }

        private string FlourType
        {
            get
            {
                return this.flourType;
            }
            set
            {
                if (value.ToLower() != "white" && value.ToLower() != "wholegrain")
                {
                    throw new ArgumentException(INVALID_DOUGH_MESSAGE);
                }

                this.flourType = value;
            }
        }

        private string BakingTechnique
        {
            get
            {
                return this.bakingTechnique;
            }
            set
            {
                if (value.ToLower() != "crispy"
                    && value.ToLower() != "chewy"
                    && value.ToLower() != "homemade")
                {
                    throw new ArgumentException(INVALID_DOUGH_MESSAGE);
                }

                this.bakingTechnique = value;
            }
        }

        private decimal Weight
        {
            get
            {
                return this.weight;
            }
            set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }

                this.weight = value;
            }
        }

        public decimal GetTotalCalories
        {
            get
            {
                return this.CalculateCalories();
            }
        }

        private decimal CalculateCalories()
        {
            return BASE_CALORIES_PER_GRAM * this.Weight * this.Modifier();
        }

        private decimal Modifier() // TODO REFACTORING
        {
            decimal flourModifier = 0;
            decimal bakingTechniqueModifier = 0;

            if (this.FlourType.ToLower() == "white")
            {
                flourModifier = WhiteFlour;
            }
            else if (this.FlourType.ToLower() == "wholegrain")
            {
                flourModifier = WholegrainFlour;
            }

            if (this.BakingTechnique.ToLower() == "crispy")
            {
                bakingTechniqueModifier = CrispyTechnique;
            }
            else if (this.BakingTechnique.ToLower() == "chewy")
            {
                bakingTechniqueModifier = ChewyTechnique;
            }
            else if (this.BakingTechnique.ToLower() == "homemade")
            {
                bakingTechniqueModifier = HomemadeTechnique;
            }

            return flourModifier * bakingTechniqueModifier;
        }
    }
}