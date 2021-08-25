using System;
using System.Collections.Generic;
using System.Linq;

namespace Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> distancesToPokemons = Console.ReadLine()
                                 .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                                 .Select(int.Parse)
                                 .ToList();

            int sum = 0;
            int removedElement = 0;

            while (distancesToPokemons.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());

                if (index < 0)
                {
                    removedElement = distancesToPokemons[0];
                    sum += removedElement;
                    distancesToPokemons.RemoveAt(0);
                    distancesToPokemons.Insert(0, distancesToPokemons[distancesToPokemons.Count - 1]);
                    distancesToPokemons = IncreaseOrDecreaseValueOfElements(distancesToPokemons, removedElement);
                }
                else if (index > distancesToPokemons.Count - 1)
                {
                    removedElement = distancesToPokemons[distancesToPokemons.Count - 1];
                    sum += removedElement;
                    distancesToPokemons.RemoveAt(distancesToPokemons.Count - 1);
                    distancesToPokemons.Add(distancesToPokemons[0]);
                    distancesToPokemons = IncreaseOrDecreaseValueOfElements(distancesToPokemons, removedElement);
                }
                else
                {
                    removedElement = distancesToPokemons[index];
                    sum += removedElement;
                    distancesToPokemons.RemoveAt(index);
                    distancesToPokemons = IncreaseOrDecreaseValueOfElements(distancesToPokemons, removedElement);
                }
            }

            Console.WriteLine(sum);
        }

        public static List<int> IncreaseOrDecreaseValueOfElements(List<int> distancesToPokemons, int removedElement)
        {
            for (int i = 0; i <= distancesToPokemons.Count - 1; i++)
            {
                if (distancesToPokemons[i] <= removedElement)
                {
                    distancesToPokemons[i] += removedElement;
                }
                else if (distancesToPokemons[i] > removedElement)
                {
                    distancesToPokemons[i] -= removedElement;
                }
            }

            return distancesToPokemons;
        }
    }
}
