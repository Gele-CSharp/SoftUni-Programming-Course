using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @">>([a-zA-Z]+)<<([0-9]+\.*[0-9]*)!([0-9]+)";
            Dictionary<string, double> boughtFurniture = new Dictionary<string, double>();
            string input = Console.ReadLine();

            while (input != "Purchase")
            {
                Match furnitureInfo = Regex.Match(input, pattern);
                
                if (furnitureInfo.Success)
                {
                    string furnitureType = furnitureInfo.Groups[1].Value;
                    double price = double.Parse(furnitureInfo.Groups[2].Value);
                    int quantity = int.Parse(furnitureInfo.Groups[3].Value);
                    double totalPrice = price * quantity;

                    if (boughtFurniture.ContainsKey(furnitureType))
                    {
                        boughtFurniture[furnitureType] += totalPrice;
                    }
                    else
                    {
                        boughtFurniture.Add(furnitureType, totalPrice);
                    }
                }
                
                input = Console.ReadLine();
            }

            Console.WriteLine("Bought furniture:");

            foreach (var item in boughtFurniture)
            {
                Console.WriteLine(item.Key);
            }

            Console.WriteLine($"Total money spend: {boughtFurniture.Values.Sum():f2}");
        }
    }
}
