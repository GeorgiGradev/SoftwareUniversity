namespace AquaShop.Models.Fish
{
    public class SaltwaterFish : Fish
    {
        private const int SaltwaterFishSize = 5;
        public SaltwaterFish(string name, string species, decimal price)
            : base(name, species, price)
        {
            this.Size = SaltwaterFishSize;
        }
      
        public override void Eat()
        {
            this.Size += 2;
        }
    }
}
