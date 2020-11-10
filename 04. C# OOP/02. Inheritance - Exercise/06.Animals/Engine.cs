using System;
using System.Linq;
using Animals.Cats;
using System.Collections.Generic;

namespace Animals
{
    public class Engine
    {
        private List<Animal> animals;

        public Engine()
        {
            this.animals = new List<Animal>();
        }

        public void Run()
        {
            string command = Console.ReadLine();

           while (command != "Beast!")
            {
                string animalType = command;
                string[] animalArguments = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                Animal animal;

                try
                {
                    animal = this.GetAnimal(animalType, animalArguments);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                    command = Console.ReadLine();
                    continue;
                }

                this.animals.Add(animal);

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(Environment.NewLine, animals));
        }

        private Animal GetAnimal(string animalType, string[] animalArguments)
        {
            string name = animalArguments[0];
            int age = int.Parse(animalArguments[1]);
            string gender = this.GetGender(animalType, animalArguments);

            Animal animal = null;

            if (animalType == "Dog")
            {
                animal = new Dog(name, age, gender);
            }
            else if (animalType == "Cat")
            {
                animal = new Cat(name, age, gender);
            }
            else if (animalType == "Frog")
            {
                animal = new Frog(name, age, gender);
            }
            else if (animalType == "Kitten")
            {
                animal = new Kitten(name, age);
            }
            else if (animalType == "Tomcat")
            {
                animal = new Tomcat(name, age);
            }
            else
            {
                throw new ArgumentException("Invalid input!");
            }

            return animal;
        }

        private string GetGender(string animalType, string[] inputAnimal)
        {
            string gender = string.Empty;

            if (animalType.Length >= 3)
            {
                gender = inputAnimal[2];
            }

            return gender;
        }
    }
}
