namespace ChristmasPastryShop.Models.Cocktails
{
    using System;
    using Contracts;
    using Utilities.Messages;

    public abstract class Cocktail : ICocktail
    {
        private string name;
        private string size;
        private double price;

        public Cocktail(string name, string size, double price)
        {
            Name = name;
            Size = size;
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

        public string Size
        {
            get { return size; }
            private set { size = value; }
        }

        public double Price
        {
            get { return price; }
            private set
            {
                switch (Size)
                {
                    case "Small":
                        price = value * 1 / 3;
                        break;
                    case "Middle":
                        price = value * 2 / 3;
                        break;
                    case "Large":
                        price = value;
                        break;
                    default:
                        break;
                }
                price = value;
            }
        }

        public override string ToString()
        {
            return $"{Name} ({Size}) - {Price:f2} lv";
        }

    }
}
