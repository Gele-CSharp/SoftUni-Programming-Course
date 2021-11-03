using System;
using System.Collections.Generic;

namespace PizzaCalories
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] productInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string productType = productInfo[0].ToLower();
            string pizzaName = string.Empty;
            string doughType = string.Empty;
            string bakingTechnique = string.Empty;
            double doughWeight = 0;
            List<Topping> toppings = new List<Topping>();

            while (productType != "end")
            {
                if (productType == "pizza")
                {
                    if (productInfo.Length == 1)
                    {
                        pizzaName = string.Empty;
                        productInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                        productType = productInfo[0].ToLower();
                        continue;
                    }

                    pizzaName = productInfo[1];
                }
                else if (productType == "dough")
                {
                    doughType = productInfo[1].ToLower();
                    bakingTechnique = productInfo[2].ToLower();
                    doughWeight = double.Parse(productInfo[3]);
                }
                else if (productType == "topping")
                {
                    string toppingType = productInfo[1].ToLower();
                    double toppingWeight = double.Parse(productInfo[2]);

                    try
                    {
                        Topping topping = new Topping(toppingType, toppingWeight);
                        toppings.Add(topping);
                    }
                    catch (ArgumentException ae)
                    {
                        Console.WriteLine(ae.Message);
                        return;
                    }
                }

                productInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                productType = productInfo[0].ToLower();
            }

            double pizzaCalories = 0;

            try
            {
                Dough dough = new Dough(doughType, bakingTechnique, doughWeight);
                Pizza pizza = new Pizza(pizzaName, dough, toppings);
                pizzaCalories = pizza.CalculateCalories();
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
                return;
            }

            Console.WriteLine($"{pizzaName} - {pizzaCalories:f2} Calories.");
        }
    }
}
