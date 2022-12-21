using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Topping
    {
        private string type;
        private double caloriesPerGram;
        private double grams;



        public Topping(string type, double grams)
        {
            if (type.ToLower() != "meat" && type.ToLower() != "veggies" && type.ToLower() != "cheese" && type.ToLower() != "sauce")
                throw new Exception($"Cannot place {type} on top of your pizza.");
            this.type = type;
            Grams = grams;
            CaloriesPerGram = caloriesPerGram;
        }


        public double Grams
        {
            get { return grams; }
            private set
            {
                if (value < 1 || value > 50)
                    throw new Exception($"{type} weight should be in the range [1..50].");
                grams = value;
            }
        }


        public double CaloriesPerGram
        {
            get { return caloriesPerGram; }
            private set
            {
                double typeModifier = type.ToLower() == "meat" ? 1.2 :
                    type.ToLower() == "veggies" ? 0.8 :
                    type.ToLower() == "cheese" ? 1.1 :
                    type.ToLower() == "sauce" ? 0.9 : 1;

                caloriesPerGram = 2 * typeModifier;
            }
        }

    }
}
