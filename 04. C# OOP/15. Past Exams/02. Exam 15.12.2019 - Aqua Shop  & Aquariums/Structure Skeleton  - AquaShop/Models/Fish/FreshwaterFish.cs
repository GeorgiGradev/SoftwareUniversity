namespace AquaShop.Models.Fish
{
    public class FreshwaterFish : Fish
    {
        private const int FreshWaterFIshSize = 3;
        public FreshwaterFish(string name, string species, decimal price)
            : base(name, species, price)
        {
            this.Size = FreshWaterFIshSize;
        }


        public override void Eat()
        {
            this.Size += 3;
        }
    }
}
