using System;
using System.Collections.Generic;
using System.Linq;

namespace Plant_Discovery
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            Dictionary<string, int> plantsRarity = new Dictionary<string, int>();
            Dictionary<string, List<double>> plantsRatings = new Dictionary<string, List<double>>();

            for (int i = 0; i < numberOfLines; i++)
            {
                string[] plantInfo = Console.ReadLine().Split(new string[] { "<->" }, StringSplitOptions.RemoveEmptyEntries);

                string plant = plantInfo[0];
                int rarity = int.Parse(plantInfo[1]);

                if (plantsRarity.ContainsKey(plant) == false)
                {
                    plantsRarity.Add(plant, rarity);
                    plantsRatings.Add(plant, new List<double>());
                }
                else
                {
                    plantsRarity[plant] = rarity;
                }
            }

            string[] command = Console.ReadLine().Split();

            while (command[0] != "Exhibition")
            {
                if (command[0] == "Rate:")
                {
                    string plant = command[1];
                    double rating = double.Parse(command[3]);

                    if (plantsRatings.ContainsKey(plant))
                    {
                        plantsRatings[plant].Add(rating);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (command[0] == "Update:")
                {
                    string plant = command[1];
                    int newRarity = int.Parse(command[3]);

                    if (plantsRarity.ContainsKey(plant))
                    {
                        plantsRarity[plant] = newRarity;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (command[0] == "Reset:")
                {
                    string plant = command[1];

                    if (plantsRatings.ContainsKey(plant))
                    {
                        plantsRatings[plant].Clear();
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }

                command = Console.ReadLine().Split();
            }

            Console.WriteLine("Plants for the exhibition:");

            foreach (var rarity in plantsRarity.OrderByDescending(p=>p.Value))
            {
                string plant = rarity.Key.ToString();

                foreach (var rating in plantsRatings.OrderByDescending(p=>p.Value.Sum()/p.Value.Count).Where(r=>r.Key == plant))
                {
                    double ratingValue = 0;

                    if (rating.Value.Count == 0)
                    {
                        ratingValue = 0;
                    }
                    else
                    {
                        ratingValue = rating.Value.Sum() / rating.Value.Count;
                    }

                    Console.WriteLine($"- {plant}; Rarity: {rarity.Value}; Rating: {ratingValue:f2}");
                }
            }
        }
    }
}
