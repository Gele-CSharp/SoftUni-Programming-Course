using System;

namespace PizzaCalories
{
    public class Dough
    {
        private string flourType;
        private string bakingTechnique;
        private double weight;

        public Dough(string flourType, string bakingTechnique, double weight)
        {
            FlourType = flourType;
            BakingTechnique = bakingTechnique;
            Weight = weight;
        }

        public string FlourType
        {
            get => flourType;

            private set
            {
                if (value != "white" && value != "wholegrain")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                flourType = value;
            }
        }

        public string BakingTechnique 
        {
            get => bakingTechnique;
            
            private set
            {
                if (value != "crispy" && value != "chewy" && value != "homemade")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                bakingTechnique = value;
            }
        }

        public double Weight 
        {
            get => weight;

            private set 
            { 
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }

                weight = value;
            }
        }

        public double CalculateCalories()
        {
            double flourTypeCalories = flourType == "white" ? 1.5 : 1;
            double bakingTechniqueCalories = bakingTechnique == "crispy" ? 0.9 : bakingTechnique == "chewy" ? 1.1 : 1;
            double totalCalories = (2 * weight) * flourTypeCalories * bakingTechniqueCalories;
            return totalCalories;
        }
    }
}
