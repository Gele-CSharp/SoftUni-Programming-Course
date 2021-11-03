using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Pizza
    {
        private string name;
        private Dough dough;
        private readonly List<Topping> toppings;

        public Pizza(string name, Dough dough, IReadOnlyCollection<Topping> toppings)
        {
            Name = name;
            Dough = dough;

            if (toppings.Count < 0 || toppings.Count > 10)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }

            this.toppings = new List<Topping>(toppings);
        }

        public string Name 
        {
            get => name;
            
            private set
            {
                if (value == "" || value.Length < 1 || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }

                name = value;
            }
        }

        public Dough Dough 
        {
            get => dough;
            
            private set
            {
                dough = value;
            }
        }

        public IReadOnlyCollection<Topping> Toppings => toppings;

        public double CalculateCalories()
        {
            double doughCalories = this.dough.CalculateCalories();
            double totalToppingCalories = 0;

            foreach (var topping in this.toppings)
            {
                double toppingCalories = topping.CalculateCalories();
                totalToppingCalories += toppingCalories;
            }

            return doughCalories + totalToppingCalories;
        }
    }
}
