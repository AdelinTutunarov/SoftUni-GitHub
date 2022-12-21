using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public class Product
    {
        private string name;
        private double cost;

        public Product(string name, double cost)
        {
            Name = name;
            Cost = cost;
        }

        public double Cost
        {
            get { return cost; }
            private set
            {
                if (value < 0) throw new Exception("Money cannot be negative");
                cost = value;
            }
        }


        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrEmpty(value)) throw new Exception("Name cannot be empty");
                name = value;
            }
        }

        public override string ToString()
        {
            return Name;
        }

    }
}
