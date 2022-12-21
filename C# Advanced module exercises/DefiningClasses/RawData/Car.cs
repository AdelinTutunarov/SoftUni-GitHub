using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Car
    {
        private string model;
        private Engine engine;
        private Cargo cargo;
        private Tire[] tires;

        public Car(string model,
            int engineSpeed,
            int enginePower,
            int cargoWeight,
            string cargoType,
            double tire1Pressure,
            int tire1Age,
            double tire2Pressure,
            int tire2Age,
            double tire3Pressure,
            int tire3Age,
            double tire4Pressure,
            int tire4Age)
        {
            Model = model;
            Engine = new Engine { Speed = engineSpeed, Power = enginePower };
            Cargo = new Cargo { Weight = cargoWeight, Type = cargoType };
            Tires = new Tire[4];
            Tires[0] = new Tire { Pressure = tire1Pressure, Age = tire1Age };
            Tires[1] = new Tire { Pressure = tire2Pressure, Age = tire2Age };
            Tires[2] = new Tire { Pressure = tire3Pressure, Age = tire3Age };
            Tires[3] = new Tire { Pressure = tire4Pressure, Age = tire4Age };
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public Engine Engine
        {
            get { return engine; }
            set { engine = value; }
        }

        public Cargo Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }

        public Tire[] Tires
        {
            get { return tires; }
            set { tires = value; }
        }

    }
}
