namespace Vehicles.Factories
{
    using Interfaces;
    using Exeptions;
    using Models;
    using Models.Interfaces;

    internal class VehicleFactory : IVehicleFactory
    {
        public IVehicle CreateVehicle(string type, double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            if (type == "Car")
            {
                IVehicle vehicle = new Car(fuelQuantity, fuelConsumption, tankCapacity);
                return vehicle;
            }
            else if (type == "Truck")
            {
                IVehicle vehicle = new Truck(fuelQuantity, fuelConsumption, tankCapacity);
                return vehicle;
            }
            else throw new InvalidVehicleTypeExeption();
        }
    }
}
