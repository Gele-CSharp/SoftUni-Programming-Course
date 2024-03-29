﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Lootbox
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> firstBox = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            Stack<int> secondBox = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            int lootValue = 0;

            while (firstBox.Count > 0 && secondBox.Count > 0)
            {
                if ((firstBox.Peek() + secondBox.Peek()) % 2 == 0)
                {
                    lootValue += firstBox.Dequeue() + secondBox.Pop();
                }
                else
                {
                    firstBox.Enqueue(secondBox.Pop());
                }
            }

            if (firstBox.Count > 0)
            {
                Console.WriteLine("Second lootbox is empty");
            }
            else
            {
                Console.WriteLine("First lootbox is empty");
            }

            if (lootValue >= 100)
            {
                Console.WriteLine($"Your loot was epic! Value: {lootValue}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {lootValue}");
            }
        }
    }
}
