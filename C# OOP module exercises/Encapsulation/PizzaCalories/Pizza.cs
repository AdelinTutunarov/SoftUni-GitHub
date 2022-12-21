using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Pizza
    {
        private string name;
        private List<Topping> toppings;
        private double totalCalories;



        public Pizza(Dough dough, string name)
        {
            Name = name;
            toppings = new List<Topping>();
            totalCalories = dough.Grams * dough.CaloriesPerGram;
        }

        public double TotalCalories
        {
            get { return totalCalories; }
        }

        public int NumberOfToppings
        {
            get { return toppings.Count; }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length > 15)
                    throw new Exception("Pizza name should be between 1 and 15 symbols.");
                name = value;
            }
        }

        public void AddTopping(Topping topping)
        {
            if (toppings.Count == 10) throw new Exception("Number of toppings should be in range [0..10].");
            toppings.Add(topping);
            totalCalories += topping.Grams * topping.CaloriesPerGram;
        }

        public override string ToString()
        {
            if (toppings.Count < 1) throw new Exception("Number of toppings should be in range [0..10].");
            return $"{Name} - {TotalCalories:f2} Calories.";
        }

    }
}
