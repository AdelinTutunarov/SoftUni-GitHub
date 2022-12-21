namespace Vehicles
{
    using IO;
    using Vehicles.Core;
    using Vehicles.Core.Interfaces;
    using Vehicles.Factories;
    using Vehicles.Factories.Interfaces;
    using Vehicles.IO.Interfaces;

    public class Program
    {
        static void Main(string[] args)
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();
            IVehicleFactory vehicleFactory = new VehicleFactory();

            IEngine engine = new Engine(reader, writer, vehicleFactory);
            engine.Run();
        }
    }
}
