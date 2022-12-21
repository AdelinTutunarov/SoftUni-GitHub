namespace Vehicles.Models
{
    using Interfaces;
    using Exeptions;
    public abstract class Vehicle : IVehicle
    {
        public Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity,  double fuelConsumptionIncrement)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption + fuelConsumptionIncrement;
            TankCapacity = tankCapacity;
            if (FuelQuantity > TankCapacity) FuelQuantity = 0;
        }

        public double FuelQuantity { get; private set; }

        public double FuelConsumption { get; protected set; }

        public double TankCapacity { get; private set; }

        public string Drive(double distance)
        {
            if (FuelQuantity < distance * FuelConsumption) return $"{this.GetType().Name} needs refueling";
            FuelQuantity -= distance * FuelConsumption;
            return $"{this.GetType().Name} travelled {distance} km";
        }

        public virtual void Refuel(double liters)
        {
            if (liters + FuelQuantity > TankCapacity) 
                throw new TooMuchFuelExeption(string.Format(TooMuchFuelExeption.DEFAULT_MESSAGE, liters));
            if (liters <= 0)
                throw new InvalidAmountOfFuelExeption();
            FuelQuantity += liters;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {FuelQuantity:f2}";
        }
    }
}
