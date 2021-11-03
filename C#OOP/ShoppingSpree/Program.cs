using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> peopleInfo = new List<string>(Console.ReadLine()
                .Split(';', StringSplitOptions.RemoveEmptyEntries)
                .ToList());

            List<string> productsInfo = new List<string>(Console.ReadLine()
                .Split(';', StringSplitOptions.RemoveEmptyEntries)
                .ToList());

            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();

            foreach (var info in peopleInfo)
            {
                try
                {
                    string[] personInfo = info.Split("=", StringSplitOptions.RemoveEmptyEntries);
                    string name = personInfo[0];
                    double money = double.Parse(personInfo[1]);
                    Person person = new Person(name, money);
                    people.Add(person);
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                    return;
                }
            }

            foreach (var info in productsInfo)
            {
                try
                {
                    string[] productInfo = info.Split("=", StringSplitOptions.RemoveEmptyEntries);
                    string name = productInfo[0];
                    double price = double.Parse(productInfo[1]);
                    Product product = new Product(name, price);
                    products.Add(product);
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                    return;
                }
            }

            while (true)
            {
                string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string personName = command[0];

                if (personName == "END")
                {
                    break;
                }

                string productName = command[1];

                people.FirstOrDefault(p=> p.Name == personName)
                    .BuyProduct(products.FirstOrDefault(p => p.Name == productName));
            }

            foreach (var person in people)
            {
                if (person.Products.Count > 0)
                {
                    Console.WriteLine($"{person.Name} - {string.Join(", ", person.Products)}");
                }
                else
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }
            }
        }
    }
}
