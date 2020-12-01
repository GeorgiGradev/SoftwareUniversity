namespace Computers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Computer
    {
		private string name;
        private List<Part> parts;

        public Computer(string name)   // 01
        { 
            this.Name = name;

            this.parts = new List<Part>(); // 02
        }

		public string Name
		{
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(this.Name), "Name cannot be null or empty!"); // 03
                }

                this.name = value;
            }
		}

        public IReadOnlyCollection<Part> Parts
            => this.parts.AsReadOnly();

        public decimal TotalPrice
            => this.Parts.Sum(x => x.Price); // 06

        public void AddPart(Part part)
        {
            if (part == null)
            {
                throw  new InvalidOperationException("Cannot add null!"); // 05
            }

            this.parts.Add(part); //04
        }

        public bool RemovePart(Part part)
            => this.parts.Remove(part); // 07

        public Part GetPart(string partName)
            => this.Parts.FirstOrDefault(x => x.Name == partName); // 08
    }
}
