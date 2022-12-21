﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    internal class SportCar : Car
    {
        private const double defaultFuelConsumption = 10;
        public SportCar(int horsePower, double fuel) : base(horsePower, fuel)
        {

        }
        public override double FuelConsumption => defaultFuelConsumption;
    }
}
