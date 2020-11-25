namespace SantaWorkshop.Models.Dwarfs
{
    using SantaWorkshop.Models.Dwarfs.Contracts;
    using SantaWorkshop.Models.Instruments.Contracts;
    using SantaWorkshop.Utilities.Messages;
    using System;
    using System.Collections.Generic;

    public abstract class Dwarf : IDwarf
    {
        private string name;
        private int energy;
        //private List<IInstrument> instruments;
        //TODO

        private Dwarf()
        {
            this.Instruments = new List<IInstrument>();
            //this.instrument = new List<IInstrument>();
        }

        protected Dwarf(string name, int energy)
            :this()
        {
            this.Name = name;
            this.Energy = energy;
        } 

        public string Name
        {
            get => this.name;
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidDwarfName);
                }
                this.name = value;
            }
        }

        public int Energy
        {
            get
            {
                return this.energy;
            }
            protected set
            {
                this.energy = value > 0 ? value : 0;
            }
        }

        public ICollection<IInstrument> Instruments { get; }
        //public ICollection<IInstrument> Instruments => this.instruments;

        public virtual void Work()
        {
            this.Energy -= 10;
        }

        public void AddInstrument(IInstrument instrument)
        {
            this.Instruments.Add(instrument);
        }

    }
}
