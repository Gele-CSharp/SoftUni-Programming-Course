using System;

namespace PizzaCalories
{
    public class Topping
    {
        private string type;
        private double weight;

        public Topping(string type, double weight)
        {
            Type = type;
            Weight = weight;
        }

        public string Type
        {
            get => type;

            private set
            {
                if (value != "meat" && value != "veggies" && value != "cheese" && value != "sauce")
                {
                    throw new ArgumentException($"Cannot place {value[0].ToString().ToUpper() + value.Substring(1)} on top of your pizza.");
                }

                type = value;
            }
        }

        public double Weight
        {
            get => weight;

            private set 
            {
                if (value < 0 || value > 50)
                {
                    throw new ArgumentException($"{Type[0].ToString().ToUpper() + Type.Substring(1)} weight should be in the range [1..50].");
                }

                weight = value;
            }
        }

        public double CalculateCalories()
        {
            double typeCalories = 0;

            switch (Type)
            {
                case "meat":
                    typeCalories = 1.2;
                    break;
                case "veggies":
                    typeCalories = 0.8;
                    break;
                case "cheese":
                    typeCalories = 1.1;
                    break;
                case "sauce":
                    typeCalories = 0.9;
                    break;
            }

            double totalCalories = (2 * weight) * typeCalories;
            return totalCalories;
        }
    }
}
