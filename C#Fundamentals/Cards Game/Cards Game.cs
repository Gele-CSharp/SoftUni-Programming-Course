using System;
using System.Collections.Generic;
using System.Linq;

namespace Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstDeckOfCards = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondDeckOfCards = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (firstDeckOfCards.Count != 0 && secondDeckOfCards.Count != 0)
            {
                int numberOfLoops = firstDeckOfCards.Count <= secondDeckOfCards.Count ?
                                                              firstDeckOfCards.Count : secondDeckOfCards.Count;

                for (int i = 0; i < numberOfLoops; i++)
                {
                    if (firstDeckOfCards[i] > secondDeckOfCards[i])
                    {
                        firstDeckOfCards.Add(firstDeckOfCards[i]);
                        firstDeckOfCards.Add(secondDeckOfCards[i]);
                        firstDeckOfCards.RemoveAt(i);
                        secondDeckOfCards.RemoveAt(i);
                    }
                    else if (secondDeckOfCards[i] > firstDeckOfCards[i])
                    {
                        secondDeckOfCards.Add(secondDeckOfCards[i]);
                        secondDeckOfCards.Add(firstDeckOfCards[i]);
                        secondDeckOfCards.RemoveAt(i);
                        firstDeckOfCards.RemoveAt(i);
                    }
                    else
                    {
                        firstDeckOfCards.RemoveAt(i);
                        secondDeckOfCards.RemoveAt(i);
                    }

                    i -= 1;
                    numberOfLoops = firstDeckOfCards.Count <= secondDeckOfCards.Count ?
                                                              firstDeckOfCards.Count - 1 : secondDeckOfCards.Count - 1;
                }
            }

            if (firstDeckOfCards.Count > 0)
            {
                Console.WriteLine($"First player wins! Sum: {firstDeckOfCards.Sum()}");
            }
            else if (secondDeckOfCards.Count > 0)
            {
                Console.WriteLine($"Second player wins! Sum: {secondDeckOfCards.Sum()}");
            }
        }
    }
}
