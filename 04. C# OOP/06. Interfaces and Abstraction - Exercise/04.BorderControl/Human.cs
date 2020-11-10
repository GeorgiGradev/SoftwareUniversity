using System;
using System.Collections.Generic;
using System.Text;

namespace _04.BorderControl
{
    public class Human : IId, IHumanable
    {
        public Human(string name, int age, string iD)
        {
            Name = name;
            Age = age;
            ID = iD;
        }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public string ID { get; private set; }
    }
}
