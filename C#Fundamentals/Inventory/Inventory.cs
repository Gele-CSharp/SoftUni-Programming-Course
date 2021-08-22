using System;
using System.Collections.Generic;
using System.Linq;

namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            string[] command = Console.ReadLine().Split('-');

            while (command[0].Trim() != "Craft!")
            {
                string item = command[1].Trim();

                switch (command[0].Trim())
                {
                    case "Collect":

                        if (items.Contains(item) == false)
                        {
                            items.Add(item);
                        }

                        break;

                    case "Drop":

                        if (items.Contains(item))
                        {
                            items.Remove(item);
                        }

                        break;

                    case "Combine Items":

                        string[] itemsToCombine = command[1].Split(':');
                        string oldItem = itemsToCombine[0].Trim();
                        string newItem = itemsToCombine[1].Trim();

                        if (items.Contains(oldItem))
                        {
                            int index = items.IndexOf(oldItem) + 1;
                            items.Insert(index, newItem);
                        }

                        break;

                    case "Renew":

                        if (items.Contains(item))
                        {
                            items.Remove(item);
                            items.Add(item);
                        }

                        break;
                }

                command = Console.ReadLine().Split(new string[] { "-" }, StringSplitOptions.RemoveEmptyEntries);
            }

            Console.Write(string.Join(", ", items));
            Console.WriteLine();
        }
    }
}
