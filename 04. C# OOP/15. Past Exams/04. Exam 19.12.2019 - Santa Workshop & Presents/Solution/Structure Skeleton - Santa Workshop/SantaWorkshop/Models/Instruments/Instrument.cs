namespace SantaWorkshop.Models.Instruments
{

    using SantaWorkshop.Models.Instruments.Contracts;

    public class Instrument : IInstrument
    {
        private int power;

        public Instrument(int power)
        {
            this.Power = power;
        }

        public int Power
        {
            get => this.power;
            private set
            {
                this.power = value < 0 ? 0 : value;
            }
        }

        public void Use()
        {
            this.Power -= 10;
        }

        public bool IsBroken() => this.Power == 0;
    }
}
 