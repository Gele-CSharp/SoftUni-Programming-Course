using System;
using System.Collections.Generic;
using System.Linq;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<Product, int> products = new Dictionary<Product, int>();
            string[] productInfo = Console.ReadLine().Split();

            while (productInfo[0] != "buy")
            {
                string name = productInfo[0];
                double price = double.Parse(productInfo[1]);
                int quantity = int.Parse(productInfo[2]);

                Product product = new Product(name, price);

                if (products.Select(p=>p.Key.Name).Contains(name))
                {
                    products.Select(p => p.Key).First(p => p.Name == name).UpdateProductPrice(price);
                    Product productToUpdate = products.Select(p => p.Key).First(p => p.Name == name);
                    products[productToUpdate] += quantity;
                }
                else
                {
                    products.Add(product, quantity);
                }

                productInfo = Console.ReadLine().Split();
            }

            foreach (var product in products)
            {
                Console.WriteLine($"{product.Key.Name} -> {product.Key.Price * product.Value:f2}" );
            }
        }
    }

    class Product
    {
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }
        public double Price { get; set; }

        public void UpdateProductPrice(double price)
        {
            this.Price = price;
            this.Name = Name;
        }
    }
}
