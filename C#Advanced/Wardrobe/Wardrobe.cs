using System;
using System.Collections.Generic;

namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> clothes = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < numberOfInputs; i++)
            {
                string[] input = Console.ReadLine().Split("->", StringSplitOptions.RemoveEmptyEntries);
                string color = input[0].Trim();
                string[] items = input[1].Split(',');

                if (clothes.ContainsKey(color) == false)
                {
                    clothes.Add(color, new Dictionary<string, int>());
                }

                for (int j = 0; j < items.Length; j++)
                {
                    string wear = items[j].Trim();

                    if (clothes[color].ContainsKey(wear) == false)
                    {
                        clothes[color].Add(wear, 0);
                    }

                    clothes[color][wear]++;
                }
            }

            string[] wantedClothes = Console.ReadLine().Split();
            string wantedColor = wantedClothes[0];
            string wantedWear = wantedClothes[1];

            foreach (var color in clothes)
            {
                Console.WriteLine($"{color.Key} clothes:");

                foreach (var wear in color.Value)
                {
                    if (color.Key != wantedColor || wear.Key != wantedWear)
                    {
                        Console.WriteLine($"* {wear.Key} - {wear.Value}");
                    }
                    else
                    {
                        Console.WriteLine($"* {wear.Key} - {wear.Value} (found!)");
                    }
                }
            }
        }
    }
}
