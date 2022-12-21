namespace Vehicles.Models
{
    public class Bus : Vehicle
    {
        private const double FUEL_CONSUMPTION_INCREMENT = 1.4;
        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity, FUEL_CONSUMPTION_INCREMENT)
        {
        }

        public string DriveEmpty(double distance)
        {
            FuelConsumption -= FUEL_CONSUMPTION_INCREMENT;
            string p = base.Drive(distance);
            FuelConsumption += FUEL_CONSUMPTION_INCREMENT;
            return p;
        }
    }
}
