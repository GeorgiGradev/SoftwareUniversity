using OnlineShop.Common.Constants;

namespace OnlineShop.Models.Products.Peripherals
{
    public abstract class Peripheral : Product, IPeripheral
    {
        protected Peripheral(int id, string manufacturer, string model, decimal price, double overallPerformance, string connectionType) 
            : base(id, manufacturer, model, price, overallPerformance)
        {
            this.ConnectionType = connectionType; 
        }

        public string ConnectionType { get; }

        public override string ToString()
        {
            return base.ToString() + string.Format(SuccessMessages.PeripheralToString, this.ConnectionType);
        }
    }
}
