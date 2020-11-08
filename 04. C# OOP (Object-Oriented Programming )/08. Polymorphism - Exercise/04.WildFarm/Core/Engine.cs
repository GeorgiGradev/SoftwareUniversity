using _04.WildFarm.Common;
using _04.WildFarm.Factories;
using _04.WildFarm.Models;
using _04.WildFarm.Models.Contracts;

using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.WildFarm.Core
{
    public class Engine : IEngine
    {
        private ICollection<IAnimal> animals;
        private FoodFactory foodFactory;

        public Engine()
        {
            this.animals = new List<IAnimal>();
            this.foodFactory = new FoodFactory();
        }

        public void Run()
        {
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] animalArg = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string[] foodArg = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                IAnimal animal = ProduceAnimal(animalArg);

                this.animals.Add(animal);

                IFood food = this.foodFactory.ProduceFood(foodArg[0], int.Parse(foodArg[1]));
                 
                Console.WriteLine(animal.ProduceSound());
                try
                {
                    animal.Feed(food);
                }
                catch (UneatableFoodException ufe)
                {
                    Console.WriteLine(ufe.Message);
                }
            }
            foreach (IAnimal animal in this.animals)
            {
                Console.WriteLine(animal);
            }
        }

        private static IAnimal ProduceAnimal(string[] animalArg)
        {
            IAnimal animal = null;

            string animalType = animalArg[0];
            string name = animalArg[1];
            double weight = double.Parse(animalArg[2]);

            if (animalType == "Owl")
            {
                double wingSize = double.Parse(animalArg[3]);
                animal = new Owl(name, weight, wingSize);
            }
            else if (animalType == "Hen")
            {
                double wingSize = double.Parse(animalArg[3]);
                animal = new Hen(name, weight, wingSize);
            }
            else
            {
                string livingRegion = animalArg[3];
                if (animalType == "Dog")
                {
                    animal = new Dog(name, weight, livingRegion);
                }
                else if (animalType == "Mouse")
                {
                    animal = new Mouse(name, weight, livingRegion);
                }
                else
                {
                    string breed = animalArg[4];
                    if (animalType == "Cat")
                    {
                        animal = new Cat(name, weight, livingRegion, breed);
                    }
                    else if (animalType == "Tiger")
                    {
                        animal = new Tiger(name, weight, livingRegion, breed);
                    }
                }
            }
            return animal;
        }
    }
}
