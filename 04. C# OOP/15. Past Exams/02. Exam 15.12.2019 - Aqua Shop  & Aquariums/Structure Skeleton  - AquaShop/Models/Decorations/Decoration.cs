using AquaShop.Models.Decorations.Contracts;

namespace AquaShop.Models
{
    public abstract class Decoration : IDecoration
    {

        protected Decoration(int comfort, decimal price)
        {
            Comfort = comfort;
            Price = price;
        }

        public int Comfort { get; private set; }
        public decimal Price { get; private set; }
    }
}
 