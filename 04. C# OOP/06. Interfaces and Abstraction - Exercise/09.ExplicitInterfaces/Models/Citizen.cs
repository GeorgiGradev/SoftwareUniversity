using Explicit_Interfaces.Models.Contracts;

namespace Explicit_Interfaces.Models
{
    public class Citizen : IResident, IPerson
    {
        public Citizen(string name, string country, int age)
        {
            Name = name;
            Country = country;
            Age = age;
        }

        public string Name { get; private set; }

        public string Country { get; private set; }

        public int Age { get; private set; }

        string IResident.GetName()
        {
            return "Mr/Ms/Mrs" + " " + this.Name;
        }
        string IPerson.GetName()
        {
            return this.Name;
        }
    }

}
