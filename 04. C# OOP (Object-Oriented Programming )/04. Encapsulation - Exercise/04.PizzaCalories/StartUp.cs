using _04.PizzaCalories.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.PizzaCalories
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            string[] pizzaNameInput = Console.ReadLine().Split();
            string pizzaName = pizzaNameInput[1];

            string[] inputArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            string flourType = inputArgs[1];
            string backingTechnique = inputArgs[2];
            double weightGrams = double.Parse(inputArgs[3]);
            double totalCalories = 0;
            List<Topping> toppingList = new List<Topping>();


            try
            {
                Dough dough = new Dough(flourType, backingTechnique, weightGrams);
                //totalCalories += double.Parse(dough.TotalCalories());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                inputArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string toppingName = inputArgs[1]; 
                weightGrams = double.Parse(inputArgs[2]);

                try
                {
                    Topping topping = new Topping(toppingName, weightGrams);
                    //totalCalories += double.Parse(topping.TotalCalories());
                    toppingList.Add(topping);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }

                if(toppingList.Count > 10)
                {
                    Console.WriteLine("Number of toppings should be in range [0..10].");
                    return;
                }

            }

            try
            {
                Pizza pizza = new Pizza(pizzaName, toppingList);
                Console.WriteLine($"{pizzaName} - {totalCalories:f2} Calories.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }





        }
    }
}
