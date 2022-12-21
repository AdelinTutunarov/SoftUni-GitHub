namespace Vehicles.Core
{
    using System;
    using Interfaces;
    using IO.Interfaces;
    using Models;
    using Models.Interfaces;
    using Factories.Interfaces;
    using System.Collections.Generic;
    using System.Linq;
    using Exeptions;

    public class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;
        private readonly IVehicleFactory vehicleFactory;

        private ICollection<IVehicle> vehicles;

        private Engine()
        {
            vehicles = new HashSet<IVehicle>();
        }

        public Engine(IReader reader, IWriter writer, IVehicleFactory vehicleFactory) : this()
        {
            this.reader = reader;
            this.writer = writer;
            this.vehicleFactory = vehicleFactory;
        }

        public void Run()
        {
            try
            {
                vehicles.Add(CreateVehicleWithFactory());
                vehicles.Add(CreateVehicleWithFactory());
                vehicles.Add(CreateVehicleWithFactory());
            }catch(InvalidVehicleTypeExeption ivte)
            {
                writer.WriteLine(ivte.Message);
            }
            int n = int.Parse(reader.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = reader.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                IVehicle vehicle = vehicles.FirstOrDefault(v => v.GetType().Name == input[1]);
                try
                {
                    if (vehicle == null) throw new InvalidVehicleTypeExeption();
                }
                catch (InvalidVehicleTypeExeption ivte)
                {
                    writer.WriteLine(ivte.Message);
                }
                try
                {
                    if (input[0] == "Drive") writer.WriteLine(vehicle.Drive(double.Parse(input[2])));
                    else if (input[0] == "DriveEmpty")
                    {
                        Bus bus = vehicles.FirstOrDefault(v => v.GetType().Name == "Bus") as Bus;
                        bus.DriveEmpty(double.Parse(input[2]));
                    }
                    else if (input[0] == "Refuel") vehicle.Refuel(double.Parse(input[2]));
                }catch (InvalidAmountOfFuelExeption iaof)
                {
                    writer.WriteLine(iaof.Message);
                }
                catch (TooMuchFuelExeption tmfe)
                {
                    writer.WriteLine(tmfe.Message);
                }
            }
            Print();
        }

        private IVehicle CreateVehicleWithFactory()
        {
            string[] input = reader.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            IVehicle vehicle = vehicleFactory.CreateVehicle(input[0], double.Parse(input[1]), double.Parse(input[2]), double.Parse(input[3]));
            return vehicle;
        }

        private void Print()
        {
            foreach (var vehicle in vehicles)
            {
                writer.WriteLine(vehicle.ToString());
            }
        }
    }
}
