namespace Vehicles.Exeptions
{
    using System;
    public class InvalidVehicleTypeExeption : Exception
    {
        private const string DEFAULT_MESSAGE = "Invalid vehicle type!";
        public InvalidVehicleTypeExeption() : base(DEFAULT_MESSAGE) {  }
        public InvalidVehicleTypeExeption(string message) : base(message) {  }
    }
}
