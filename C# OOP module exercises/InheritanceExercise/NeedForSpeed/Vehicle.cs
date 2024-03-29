﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Vehicle
    {
		private const double defaultFuelConsumption = 1.25;

        public Vehicle(int horsePower, double fuel)
        {
            HorsePower = horsePower;
            Fuel = fuel;
        }

		public virtual double FuelConsumption => defaultFuelConsumption;
        public double Fuel { get; set; }
        public int HorsePower  { get; set; }
        public virtual void Drive(double kilometers)
        {
            if(Fuel - kilometers * FuelConsumption >= 0) Fuel -= kilometers * FuelConsumption;
        }
    }
}
