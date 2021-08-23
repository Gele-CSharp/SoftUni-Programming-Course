using System;
using System.Collections.Generic;
using System.Linq;

namespace Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] materialsInfo = Console.ReadLine().Split();
            Dictionary<string, int> materials = new Dictionary<string, int>()
            {
                { "shards", 0 },
                { "fragments", 0 },
                { "motes", 0 }
            };

            Dictionary<string, int> junk = new Dictionary<string, int>();
            bool isNotObtained = true;
            string legendaryItem = string.Empty;

            while (isNotObtained)
            {
                int quantity = 0;
                string material = string.Empty;

                for (int i = 0; i < materialsInfo.Length - 1; i += 2)
                {
                    quantity = int.Parse(materialsInfo[i]);
                    material = materialsInfo[i + 1].ToLower();

                    if (material == "shards" || material == "fragments" || material == "motes")
                    {
                        materials[material] += quantity;

                        if (materials[material] >= 250)
                        {
                            isNotObtained = false;
                            materials[material] -= 250;

                            if (material == "shards")
                            {
                                legendaryItem = "Shadowmourne";
                            }
                            else if (material == "fragments")
                            {
                                legendaryItem = "Valanyr";
                            }
                            else if (material == "motes")
                            {
                                legendaryItem = "Dragonwrath";
                            }

                            break;
                        }
                    }
                    else 
                    {
                        if (junk.ContainsKey(material))
                        {
                            junk[material] += quantity;
                        }
                        else
                        {
                            junk.Add(material, quantity);
                        }
                    }
                }

                if (isNotObtained == false)
                {
                    break;
                }

                materialsInfo = Console.ReadLine().Split();
            }

            Console.WriteLine($"{legendaryItem} obtained!");

            foreach (var material in materials.OrderByDescending(m=>m.Value).ThenBy(m=>m.Key))
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }

            foreach (var item in junk.OrderBy(j=>j.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
