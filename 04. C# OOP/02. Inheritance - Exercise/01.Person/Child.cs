using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace Person
{
    public class Child : Person
    {
        private int age;
        public Child(string name, int age) 
            : base(name, age)
        {

        }

        public override int Age
        {
            get 
            { 
                return base.Age; 
            }
            set
            {
                if (value > 15)
                {
                    throw new ArgumentException("Child age must be less than 15");
                }
                base.Age = value; 
            }
        }

    }
}
