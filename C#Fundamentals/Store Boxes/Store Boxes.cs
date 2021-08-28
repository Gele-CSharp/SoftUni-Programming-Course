using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Store_Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();

            string[] productInfo = Console.ReadLine().Split();

            while (productInfo[0] != "end")
            {
                string serialNumber = productInfo[0];
                string name = productInfo[1];
                int itemQuantity = int.Parse(productInfo[2]);
                double itemPrice = double.Parse(productInfo[3]);

                Item item = new Item(name, itemPrice);

                double boxPrice = itemPrice * itemQuantity;

                Box box = new Box(item, serialNumber, itemQuantity, boxPrice);

                boxes.Add(box);

                productInfo = Console.ReadLine().Split();
            }

            foreach (Box box in boxes.OrderByDescending(b=>b.Price))
            {
                Console.WriteLine(box);
            }
        }
    }

    class Item
    {
        public Item(string name, double itemPrice)
        {
            Name = name;
            ItemPrice = itemPrice;
        }

        public string Name { get; set; }
        public double ItemPrice { get; set; }
    }

    class Box
    {
        public Box(Item item, string serialNumber, int itemQuantity, double price)
        {
            Item = item;
            SerialNumber = serialNumber;
            ItemQuantity = itemQuantity;
            Price = price;
        }

        public Item Item { get; set; }
        public string SerialNumber { get; set; }
        public int ItemQuantity { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{SerialNumber}");
            sb.AppendLine($"-- {Item.Name} - ${Item.ItemPrice:f2}: {ItemQuantity}");
            sb.AppendLine($"-- ${Price:f2}");
            

            return sb.ToString().Trim();
        }
    }
}
