using System;
using System.Collections.Generic;
using System.Linq;

namespace Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[] command = Console.ReadLine().Split();
            
            while (command[0] != "end")
            {
                if (command[0] == "max")
                {
                    string type = command[1];
                    PrintIndexOfMax(array, type);
                }
                else if (command[0] == "min")
                {
                    string type = command[1];
                    PrintIndexOfMin(array, type);
                }
                else if (command[0] == "first")
                {
                    int count = int.Parse(command[1]);
                    string type = command[2];
                    PrintCertainOfFirstElements(array, count, type);
                }
                else if (command[0] == "last")
                {
                    int count = int.Parse(command[1]);
                    string type = command[2];
                    PrintCertainOfLastElements(array, count, type);
                }

                if (command[0] == "exchange")
                {
                    int index = int.Parse(command[1]);

                    if (index < 0 || index > array.Length - 1)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        array = ExchangeArray(array, index);
                        Console.WriteLine($"[{string.Join(", ", array)}]");
                    }
                }

                command = Console.ReadLine().Split();
            }
        }

        public static int[] ExchangeArray(int[] array, int index)
        {
            int[] manipulatedArray = new int[array.Length];
            
            for (int i = 0; i < array.Length; i++)
            {
                if (i >= (array.Length - 1) - index)
                {
                    manipulatedArray[i] = array[i - ((array.Length - 1) - index)];
                }
                else
                {
                    manipulatedArray[i] = array[i + index + 1];
                }
            }

            return manipulatedArray;
        }

        public static void PrintIndexOfMax(int[] array, string evenOrOdd)
        {
            int max = int.MinValue;
            int rightmostIndex = 0;
            bool isMax = false;

            for (int i = 0; i < array.Length; i++)
            {
                if (evenOrOdd == "even")
                {
                    if (array[i] % 2 == 0 && array[i] > max && i >= rightmostIndex)
                    {
                        max = array[i];
                        rightmostIndex = i;
                        isMax = true;
                    }
                }
                else
                {
                    if (array[i] % 2 != 0 && array[i] > max && i >= rightmostIndex)
                    {
                        max = array[i];
                        rightmostIndex = i;
                        isMax = true;
                    }
                }
            }

            if (isMax)
            {
                Console.WriteLine(rightmostIndex);
            }
            else
            {
                Console.WriteLine("No matches");
            }
            
        }

        public static void PrintIndexOfMin(int[] array, string evenOrOdd)
        {
            int min = int.MaxValue;
            int rightmostIndex = 0;
            bool isMin = false;

            for (int i = 0; i < array.Length; i++)
            {
                if (evenOrOdd == "even")
                {
                    if (array[i] % 2 == 0 && array[i] < min && i >= rightmostIndex)
                    {
                        min = array[i];
                        rightmostIndex = i;
                        isMin = true;
                    }
                }
                else
                {
                    if (array[i] % 2 != 0 && array[i] < min && i >= rightmostIndex)
                    {
                        min = i;
                        rightmostIndex = i;
                        isMin = true;
                    }
                }
            }

            if (isMin)
            {
                Console.WriteLine(rightmostIndex);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        public static void PrintCertainOfFirstElements(int[] array, int count, string type)
        {
            int counter = 0;
            List<int> numbers = new List<int>();

            if (count > array.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (type == "even" && counter < count)
                    {
                        if (array[i] % 2 == 0)
                        {
                            numbers.Add(array[i]);
                            counter++;
                        }
                    }
                    else if (type == "odd" && counter < count)
                    {
                        if (array[i] % 2 != 0)
                        {
                            numbers.Add(array[i]);
                            counter++;
                        }
                    }
                }

                Console.WriteLine($"[{string.Join(", ", numbers)}]");
            }
        }

        public static void PrintCertainOfLastElements(int[] array, int count, string type)
        {
            int counter = 0;
            List<int> numbers = new List<int>();

            if (count > array.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                for (int i = array.Length - 1; 0 <= i; i--)
                {
                    if (type == "even" && counter <= count)
                    {
                        if (array[i] % 2 == 0)
                        {
                            numbers.Add(array[i]);
                            counter++;
                        }
                    }
                    else if (type == "odd" && counter <= count)
                    {
                        if (array[i] % 2 != 0)
                        {
                            numbers.Add(array[i]);
                            counter++;
                        }
                    }
                }

                Console.WriteLine($"[{string.Join(", ", numbers)}]");
            }
        }
    }
}
