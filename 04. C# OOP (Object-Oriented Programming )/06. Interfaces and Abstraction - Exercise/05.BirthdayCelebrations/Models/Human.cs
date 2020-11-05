using BirthdayCelebrations.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations.Models
{
    public class Human : IIdentifiable, IHumanable, IDatable
    {
        public Human(string name, int age, string iD, string birthDate)
        {
            Name = name;
            Age = age;
            ID = iD;
            BirthDate = birthDate;
        }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public string ID { get; private set; }
        public string BirthDate { get; set; }
    }
}
