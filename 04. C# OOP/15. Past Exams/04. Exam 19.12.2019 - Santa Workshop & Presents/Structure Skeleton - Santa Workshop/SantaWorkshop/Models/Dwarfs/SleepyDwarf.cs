namespace SantaWorkshop.Models.Dwarfs
{
    public class SleepyDwarf : Dwarf
    {
        private const int SleepyDwarfInitialEnergy = 50;

        public SleepyDwarf(string name) 
            : base(name, SleepyDwarfInitialEnergy)
        {
        }

        public override void Work()
        {
            base.Work();
            this.Energy -= 5;
        }
    }
}
