namespace Bakery.Models.BakedFoods
{
    public class Cake : BakedFood
    {
        private const int CakeInitialPortion = 245;

        public Cake(string name, decimal price) 
            : base(name, CakeInitialPortion, price)
        {}
    }
}
