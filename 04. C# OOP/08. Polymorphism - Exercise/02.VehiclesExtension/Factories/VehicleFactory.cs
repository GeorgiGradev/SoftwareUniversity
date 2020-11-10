using System;

namespace Vehicles.Factories
{
    public class VehicleFactory
    {
        public Vehicle ProduceVehicle(string vehicleType, double fuelQuantity, double fuelConsumption, double carTankCapacity)
        {
            string baseNamespace = "Vehicles.Models";

            Type type = Type.GetType($"{baseNamespace}.{vehicleType}");

            Vehicle vehicle = (Vehicle)Activator.CreateInstance(type, fuelQuantity, fuelConsumption, carTankCapacity);

            return vehicle;
        }
    }
}
