using System;
using System.Collections.Generic;

namespace A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string resource = Console.ReadLine();
            Dictionary<string, int> resources = new Dictionary<string, int>();

            while (resource != "stop")
            {
                int quantityOfResource = int.Parse(Console.ReadLine());

                if (resources.ContainsKey(resource))
                {
                    resources[resource] += quantityOfResource;
                }
                else
                {
                    resources.Add(resource, quantityOfResource);
                }

                resource = Console.ReadLine();
            }

            foreach (var element in resources)
            {
                Console.WriteLine($"{element.Key} -> {element.Value}");
            }
        }
    }
}
