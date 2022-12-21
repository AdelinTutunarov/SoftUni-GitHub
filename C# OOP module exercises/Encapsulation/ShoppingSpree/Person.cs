using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace ShoppingSpree
{
    public class Person
    {
        private string name;
        private double money;
        private List<Product> bagOfProducts;

        public Person(string name, double money)
        {
            Name = name;
            Money = money;
            bagOfProducts = new List<Product>();
        }

        public double Money
        {
            get { return money; }
            private set
            {
                if (value < 0) throw new Exception("Money cannot be negative");
                money = value;
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

        public void Buy(Product product)
        {
            if (product.Cost > Money)
            {
                Console.WriteLine($"{Name} can't afford {product.Name}");
                return;
            }
            Money -= product.Cost;
            bagOfProducts.Add(product);
            Console.WriteLine($"{Name} bought {product.Name}");
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (bagOfProducts.Count == 0)
            {
                sb.Append($"{Name} - Nothing bought");
                return sb.ToString();
            }
            sb.Append($"{Name} - {string.Join(", ", bagOfProducts)}");
            return sb.ToString();
        }
    }
}
