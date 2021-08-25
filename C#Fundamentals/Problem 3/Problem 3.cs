using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> products = Console.ReadLine().Split('|').ToList();
            string[] command = Console.ReadLine().Split('%');

            while (command[0] != "Shop!")
            {
                string product = command[1];

                if (command[0] == "Important")
                {
                    if (products.Contains(product))
                    {
                        products.Remove(product);
                        products.Insert(0, product);
                    }
                    else
                    {
                        products.Insert(0, product);
                    }
                }
                else if (command[0] == "Add")
                {
                    if (products.Contains(product) == false)
                    {
                        products.Add(product);
                    }
                    else
                    {
                        Console.WriteLine("The product is already in the list.");
                    }
                }
                else if (command[0] == "Swap")
                {
                    string productToSwap = command[2];

                    if (products.Contains(product) && products.Contains(productToSwap))
                    {
                        int indexOfProduct = products.IndexOf(product);
                        int indexOfProductToSwap = products.IndexOf(productToSwap);

                        products.RemoveAt(indexOfProduct);
                        products.Insert(indexOfProduct, productToSwap);

                        products.RemoveAt(indexOfProductToSwap);
                        products.Insert(indexOfProductToSwap, product);
                    }
                    else
                    {
                        string missingProduct = products.Contains(product) == false ? product : productToSwap;
                        Console.WriteLine($"Product {missingProduct} missing!");
                    }
                }
                else if (command[0] == "Remove")
                {
                    if (products.Contains(product))
                    {
                        products.Remove(product);
                    }
                    else
                    {
                        Console.WriteLine($"Product {product} isn't in the list.");
                    }
                }
                else if (command[0] == "Reversed")
                {
                    products.Reverse();
                }

                command = Console.ReadLine().Split('%');
            }
            
            for (int i = 1; i <= products.Count; i++)
            {
                Console.WriteLine($"{i}. {products[i-1]}");
            }
        }
    }
}
