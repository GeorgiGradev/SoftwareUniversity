namespace Vehicles.Models
{
    public  class Bus : Vehicle
    {
        private const double ADDITIONAL_CONSUMPTION_PER_KM = 1.4;

        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {

        }

        protected override double AdditionalConsumption => ADDITIONAL_CONSUMPTION_PER_KM;
    }
}
