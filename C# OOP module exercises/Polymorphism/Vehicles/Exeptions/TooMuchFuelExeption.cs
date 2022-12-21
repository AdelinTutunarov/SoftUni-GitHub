namespace Vehicles.Exeptions
{
    using System;
    public class TooMuchFuelExeption : Exception
    {
        public const string DEFAULT_MESSAGE = "Cannot fit {0} fuel in the tank";
        public TooMuchFuelExeption() : base(DEFAULT_MESSAGE) { }
        public TooMuchFuelExeption(string message) : base(message) { }
    }
}
