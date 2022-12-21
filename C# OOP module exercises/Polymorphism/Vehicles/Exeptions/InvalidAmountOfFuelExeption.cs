namespace Vehicles.Exeptions
{
    using System;
    public class InvalidAmountOfFuelExeption : Exception
    {
        private const string DEFAULT_MESSAGE = "Fuel must be a positive number";
        public InvalidAmountOfFuelExeption() : base(DEFAULT_MESSAGE) { }
        public InvalidAmountOfFuelExeption(string message) : base(message) { }
    }
}
