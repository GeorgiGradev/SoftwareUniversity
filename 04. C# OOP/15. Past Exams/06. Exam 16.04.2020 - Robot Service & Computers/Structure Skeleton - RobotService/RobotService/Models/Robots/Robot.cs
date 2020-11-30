namespace RobotService.Models.Robots.Contracts
{
    using System;

    using RobotService.Utilities.Messages;

    public abstract class Robot : IRobot
    {
        private int happiness;
        private int energy;

        protected Robot(string name, int energy, int happiness,  int procedureTime)
        {
            this.Name = name;
            this.Energy = energy;
            this.Happiness = happiness;
            this.ProcedureTime = procedureTime;
            this.Owner = "Servive";
        }

        public string Name { get; }
        public int Happiness
        {
            get => this.happiness;
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidHappiness);
                }
                this.happiness = value;
            }
        }
        public int Energy
        {
            get => this.energy;
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidEnergy);
                }
                this.energy = value;
            }
        }

        public int ProcedureTime { get; set; }
        public string Owner { get; set; } // TODO да се пробва и по този начин =>  public string Owner { get; set; } = "Service";
        public bool IsBought { get; set; }
        public bool IsChipped { get; set; }
        public bool IsChecked { get; set; }


        public override string ToString()
        {
            return $" Robot type: {this.GetType().Name} - {this.Name} - Happiness: {this.Happiness} - Energy: {this.Energy}";
        }
    }
}
