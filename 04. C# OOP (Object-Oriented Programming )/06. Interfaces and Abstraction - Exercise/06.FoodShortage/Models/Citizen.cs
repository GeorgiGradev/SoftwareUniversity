using FoodShortage.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage.Models
{
    public class Citizen : IIdentifiable, IHumanable, IDatable, IBuyer
    {
        public Citizen(string name, int age, string iD, string birthDate)
        {
            Name = name;
            Age = age;
            ID = iD;
            BirthDate = birthDate;
        }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public string ID { get; private set; }
        public string BirthDate { get; private set; }

        public int Food { get; private set; }

        public int BuyFood()
        {
            int food = 10;
            return food;
        }
    }
}
