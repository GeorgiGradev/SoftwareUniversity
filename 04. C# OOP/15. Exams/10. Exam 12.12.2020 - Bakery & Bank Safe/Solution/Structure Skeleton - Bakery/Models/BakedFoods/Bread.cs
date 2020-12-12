namespace Bakery.Models.BakedFoods
{
    public class Bread : BakedFood
    {
        private const int BreadInitialPortion = 200;

        public Bread(string name, decimal price) 
            : base(name, BreadInitialPortion, price)
        {}
    }
}
