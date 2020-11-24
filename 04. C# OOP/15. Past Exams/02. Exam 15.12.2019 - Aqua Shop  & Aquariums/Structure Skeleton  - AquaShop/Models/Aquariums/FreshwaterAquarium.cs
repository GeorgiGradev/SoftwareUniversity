namespace AquaShop.Models.Aquariums
{
    public class FreshwaterAquarium : Aquarium
    {
        private const int FreshwaterAquariumCapacity = 50;
        public FreshwaterAquarium(string name) 
            : base(name, FreshwaterAquariumCapacity)
        {

        }
    }
}
