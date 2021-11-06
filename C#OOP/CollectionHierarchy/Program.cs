using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionHierarchy
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            AddCollection collection1 = new AddCollection();
            AddRemoveCollection collection2 = new AddRemoveCollection();
            AddRemoveCollection collection3 = new MyList();
            List<int> collection1AddedElementsIndexses = new List<int>();
            List<int> collection2AddedElementsIndexses = new List<int>();
            List<int> collection3AddedElementsIndexses = new List<int>();
            List<string> collection2RemovedElements = new List<string>();
            List<string> collection3RemovedElements = new List<string>();

            for (int i = 0; i < elements.Count; i++)
            {
                collection1AddedElementsIndexses.Add(collection1.Add(elements[i]));
                collection2AddedElementsIndexses.Add(collection2.Add(elements[i]));
                collection3AddedElementsIndexses.Add(collection3.Add(elements[i]));
            }

            int numberOfRemoves = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfRemoves; i++)
            {
                string collection2Result = collection2.Remove();
                string collection3Result = collection3.Remove();

                collection2RemovedElements.Add(collection2Result);
                collection3RemovedElements.Add(collection3Result);
            }

            Console.WriteLine(string.Join(" ", collection1AddedElementsIndexses));
            Console.WriteLine(string.Join(" ", collection2AddedElementsIndexses));
            Console.WriteLine(string.Join(" ", collection3AddedElementsIndexses));
            Console.WriteLine(string.Join(" ", collection2RemovedElements));
            Console.WriteLine(string.Join(" ", collection3RemovedElements));
            
        }
    }
}
