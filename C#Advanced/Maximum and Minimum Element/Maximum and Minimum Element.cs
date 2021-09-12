using System;
using System.Collections.Generic;
using System.Linq;

namespace Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberofQueries = int.Parse(Console.ReadLine());
            Stack<int> elements = new Stack<int>();

            for (int i = 0; i < numberofQueries; i++)
            {
                int[] query = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int action = query[0];

                switch (action)
                {
                    case 1:

                        int element = query[1];
                        elements.Push(element);

                        break;
                    case 2:

                        if (elements.Count > 0)
                        {
                            elements.Pop();
                        }
                        
                        break;
                    case 3:

                        if (elements.Count > 0)
                        {
                            int maxElement = int.MinValue;

                            foreach (int member in elements)
                            {
                                if (member > maxElement)
                                {
                                    maxElement = member;
                                }
                            }

                            Console.WriteLine(maxElement);
                        }

                        break;
                    case 4:

                        if (elements.Count > 0)
                        {
                            int minElement = int.MaxValue;

                            foreach (int memeber in elements)
                            {
                                if (memeber < minElement)
                                {
                                    minElement = memeber;
                                }
                            }

                            Console.WriteLine(minElement);
                        }

                        break;
                    default:

                        Console.WriteLine("Invalid query!");
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", elements));
        }
    }
}
