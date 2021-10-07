using System;
using System.Collections.Generic;
using System.Linq;

namespace Masterchef2
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> ingredientValues = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            Stack<int> freshnessLevel = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            List<Dish> dishes = new List<Dish>()
            {
                new Dish("Dipping sauce", 150),
                new Dish("Green salad", 250),
                new Dish("Chocolate cake", 300),
                new Dish("Lobster", 400)
            };

            while (ingredientValues.Count > 0 && freshnessLevel.Count > 0)
            {
                if(ingredientValues.Peek() == 0)
                {
                    ingredientValues.Dequeue();
                    continue;
                }

                int neededFreshnessLevel = ingredientValues.Peek() * freshnessLevel.Pop();
                bool isDishMade = false;

                for (int i = 0; i < dishes.Count; i++)
                {
                    if (dishes[i].Freshness == neededFreshnessLevel)
                    {
                        dishes[i].Count++;
                        ingredientValues.Dequeue();
                        isDishMade = true;
                        break;
                    }
                }

                if (isDishMade == false)
                {
                    ingredientValues.Enqueue(ingredientValues.Dequeue() + 5);
                }
            }

            List<Dish> output = dishes.OrderBy(d=> d.Name).Where(d => d.Count > 0).ToList();

            if (output.Count == 4)
            {
                Console.WriteLine("Applause! The judges are fascinated by your dishes!");
            }
            else
            {
                Console.WriteLine("You were voted off. Better luck next year.");
            }

            if (ingredientValues.Count > 0)
            {
                Console.WriteLine($"Ingredients left: {ingredientValues.Sum()}");
            }

            foreach (var dish in output)
            {
                Console.WriteLine($" # {dish.Name} --> {dish.Count}");
            }
        }
    }
}

public class Dish
{
    public Dish(string name, int freshness)
    {
        Name = name;
        Freshness = freshness;
    }

    public string Name { get; set; }
    public int Freshness { get; set; }
    public int Count { get; set; }
}
