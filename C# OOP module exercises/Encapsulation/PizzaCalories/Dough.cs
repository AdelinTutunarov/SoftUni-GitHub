using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Dough
    {

        private string flourType;
        private string bakingTechnique;
        private double caloriesPerGram;
        private double grams;



        public Dough(string flourType, string bakingTechnique, double grams)
        {
            if (flourType.ToLower() != "white" && flourType.ToLower() != "wholegrain")
                throw new Exception("Invalid type of dough.");

            this.flourType = flourType;

            if (bakingTechnique.ToLower() != "crispy" && bakingTechnique.ToLower() != "chewy" && bakingTechnique.ToLower() != "homemade")
                throw new Exception("Invalid type of dough.");

            this.bakingTechnique = bakingTechnique;
            Grams = grams;
            CaloriesPerGram = caloriesPerGram;
        }

        public double Grams
        {
            get { return grams; }
            private set
            {
                if (value < 1 || value > 200)
                    throw new Exception("Dough weight should be in the range [1..200].");
                grams = value;
            }
        }

        public double CaloriesPerGram
        {
            get { return caloriesPerGram; }
            private set
            {
                double flourTypeModifier = this.flourType.ToLower() == "white" ? 1.5 :
                this.flourType.ToLower() == "wholegrain" ? 1 : 1;
                double bakingTechniqueModifier = this.bakingTechnique.ToLower() == "crispy" ? 0.9 :
                    this.bakingTechnique.ToLower() == "chewy" ? 1.1 :
                    this.bakingTechnique.ToLower() == "homemade" ? 1 : 1;

                caloriesPerGram = 2 * flourTypeModifier * bakingTechniqueModifier;
            }
        }

    }

}
