namespace SantaWorkshop.Models.Dwarfs
{
    public class HappyDwarf : Dwarf
    {
        private const int HappyDwarfInitialEnergy = 100;
        public HappyDwarf(string name) 
            : base(name, HappyDwarfInitialEnergy)
        {
        }

    }
}
