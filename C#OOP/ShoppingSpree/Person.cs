using System;
using System.Collections.Generic;

namespace ShoppingSpree
{
    public class Person
    {
        private string name;
        private double money;
        private readonly List<Product> products;

        public Person(string name, double money)
        {
            Name = name;
            Money = money;
            products = new List<Product>();
        }

        public string Name 
        {
            get => name;
            
            private set
            {
                if (value == "")
                {
                    throw new ArgumentException("Name cannot be empty");
                }

                name = value;
            }
        }

        public double Money 
        {
            get => money;
            
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }

                money = value;
            }
        }

        public IReadOnlyList<Product> Products => products;

        public void BuyProduct(Product product)
        {
            if (money >= product.Price)
            {
                money -= product.Price;
                products.Add(product);
                Console.WriteLine($"{Name} bought {product.Name}");
            }
            else
            {
                Console.WriteLine($"{Name} can't afford {product.Name}");
            }
        }
    }
}
