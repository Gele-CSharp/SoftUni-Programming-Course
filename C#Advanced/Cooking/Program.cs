using System;
using System.Collections.Generic;
using System.Linq;

namespace Cooking
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> liquids = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            Stack<int> ingrediants = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            var foods = new Dictionary<string, Dictionary<string, int>>()
            {
                { "Bread", new Dictionary<string, int>(){ {"25", 0 } } },
                { "Cake", new Dictionary<string, int>(){ {"50", 0 } } },
                { "Pastry", new Dictionary<string, int>(){ {"75", 0 } } },
                { "Fruit Pie", new Dictionary<string, int>(){ {"100", 0 } } },
            };


            while (liquids.Count > 0 && ingrediants.Count > 0)
            {
                string currentValue = (liquids.Peek() + ingrediants.Peek()).ToString();
                bool isDishMade = false;

                foreach (var dish in foods)
                {
                    if (dish.Value.ContainsKey(currentValue))
                    {
                        liquids.Dequeue();
                        ingrediants.Pop();
                        dish.Value[currentValue]++;
                        isDishMade = true;
                        break; 
                    }
                }

                if (isDishMade == false)
                {
                    liquids.Dequeue();
                    ingrediants.Push(ingrediants.Pop() + 3);
                }
            }

            int countOfMadeDishes = 0;

            foreach (var food in foods)
            {
                foreach (var item in food.Value)
                {
                    if (item.Value > 0)
                    {
                        countOfMadeDishes++;
                    }
                }
            }

            if (countOfMadeDishes == 4)
            {
                Console.WriteLine("Wohoo! You succeeded in cooking all the food!");
            }
            else if (countOfMadeDishes < 4)
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to cook everything.");
            }

            if (liquids.Count > 0)
            {
                Console.WriteLine($"Liquids left: {string.Join(", ", liquids)}");
            }
            else
            {
                Console.WriteLine("Liquids left: none");
            }

            if (ingrediants.Count > 0)
            {
                Console.WriteLine($"Ingredients left: {string.Join(", ", ingrediants)}");
            }
            else
            {
                Console.WriteLine("Ingredients left: none");
            }

            foreach (var dish in foods.OrderBy(d=> d.Key))
            {
                foreach (var item in dish.Value)
                {
                    Console.WriteLine($"{dish.Key}: {item.Value}");
                }
            }
        }
    }
}
