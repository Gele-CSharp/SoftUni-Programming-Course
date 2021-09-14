using System;
using System.Collections.Generic;

namespace Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var shops = new SortedDictionary<string, Dictionary<string, double>>();
            string[] commands = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            while (commands[0] != "Revision")
            {
                string shop = commands[0];
                string product = commands[1];
                double price = double.Parse(commands[2]);

                if (shops.ContainsKey(shop) == false)
                {
                    shops.Add(shop, new Dictionary<string, double>());
                }

               shops[shop].Add(product, price);

                commands = commands = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var shop in shops)
            {
                Console.WriteLine($"{shop.Key}->");

                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
