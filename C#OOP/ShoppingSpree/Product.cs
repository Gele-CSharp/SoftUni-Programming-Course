using System;

namespace ShoppingSpree
{
    public class Product
    {
        private string name;
        private double price;

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
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

        public double Price
        {
            get => price;

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }

                price = value;
            }
        }

        public override string ToString()
        {
            return Name.ToString();
        }
    }
}