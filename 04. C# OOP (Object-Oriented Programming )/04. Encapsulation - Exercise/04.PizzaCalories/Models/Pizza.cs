using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace _04.PizzaCalories.Models
{
    public class Pizza
    {
        private string pizzaName;
        private List<Topping> toppingList;


        public Pizza(string pizzaName, List<Topping> toppingList)
        {
            this.PizzaName = pizzaName;
            this.toppingList = new List<Topping>();
        }

        public int Count => this.toppingList.Count;


        public string PizzaName
        {
            get
            {
                return this.pizzaName;
            }
            private set
            {
                if (string.IsNullOrEmpty(value) || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                this.pizzaName = value;
            }

        }




    }
}
