﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Coffee : HotBeverage
    {
        private const decimal coffeePrice = 3.50M;
        private const double coffeeMilliliters = 50;
        public Coffee(string name, double caffeine) : base(name, coffeePrice, coffeeMilliliters)
        {
            Caffeine = caffeine;
        }

        public override decimal Price => coffeePrice;
        public override double Milliliters => coffeeMilliliters;
        public double Caffeine  { get; set; }
    }
}
