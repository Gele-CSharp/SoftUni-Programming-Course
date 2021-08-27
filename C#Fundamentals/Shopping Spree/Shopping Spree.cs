using System;
using System.Collections.Generic;
using System.Linq;

namespace Shopping_Spree
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] personsInfo = Console.ReadLine().Split(';');
            List<Person> persons = new List<Person>(personsInfo.Length);

            for (int i = 0; i < personsInfo.Length; i++)
            {
                string[] personInfo = personsInfo[i].Split('=');
                string name = personInfo[0];
                double money = double.Parse(personInfo[1]);

                Person person = new Person(name, money);
                persons.Add(person);
            }

            string[] productsInfo = Console.ReadLine().Split(';');
            List<Product> products = new List<Product>(productsInfo.Length);

            for (int i = 0; i < productsInfo.Length; i++)
            {
                string[] productInfo = productsInfo[i].Split('=');
                string productName = productInfo[0];
                double price = double.Parse(productInfo[1]);

                Product product = new Product(productName, price);
                products.Add(product);
            }

            string[] purchases = Console.ReadLine().Split();

            while (purchases[0] != "END")
            {
                string name = purchases[0];
                string productName = purchases[1];

                persons.Find(p => p.Name == name).BuyProduct(products.Find(p=>p.ProductName == productName));

                purchases = Console.ReadLine().Split();
            }

            foreach (Person person in persons.Where(p=>p.Products.Count > 0))
            {
                Console.WriteLine($"{person.Name} - {string.Join(", ", person.Products.Select(p=>p.ProductName))}");
            }

            foreach (Person person in persons.Where(p=>p.Products.Count == 0))
            {
                Console.WriteLine($"{person.Name} - Nothing bought");
            }
        }
    }

    class Product
    {
        public Product(string productName, double price)
        {
            ProductName = productName;
            Price = price;
        }

        public string ProductName { get; set; }
        public double Price { get; set; }
    }

    class Person
    {
        public Person(string name, double money)
        {
            Name = name;
            Money = money;
        }

        public string Name { get; set; }
        public double Money { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();

        public void BuyProduct (Product product)
        {

            if (product.Price > this.Money)
            {
                Console.WriteLine($"{this.Name} can't afford {product.ProductName}");
            }
            else
            {
               this.Products.Add(product);
                this.Money -= product.Price;
                Console.WriteLine($"{this.Name} bought {product.ProductName}");
            }
        }
    }
}
