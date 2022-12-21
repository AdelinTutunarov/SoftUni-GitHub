﻿namespace ChristmasPastryShop.Models.Delicacies
{
    using ChristmasPastryShop.Utilities.Messages;
    using Contracts;
    using System;

    public abstract class Delicacy : IDelicacy
    {
        private string name;
        private double price;

        public Delicacy(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException(ExceptionMessages.NameNullOrWhitespace);

                name = value;
            }
        }

        public double Price
        {
            get { return price; }
            private set { price = value; }
        }

        public override string ToString()
        {
            return $"{Name} - {Price:f2} lv";
        }

    }
}
