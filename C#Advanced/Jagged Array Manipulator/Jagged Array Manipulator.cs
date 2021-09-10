using System;
using System.Linq;

namespace Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfRows = int.Parse(Console.ReadLine());
            long[][] jaggedArray = new long[numberOfRows][];

            for (int row = 0; row < numberOfRows; row++)
            {
                long[] elements = Console.ReadLine()
                                .Split()
                                .Select(long.Parse)
                                .ToArray();

                jaggedArray[row] = elements;
            }

            for (int row = 0; row < numberOfRows - 1; row++)
            {
                int numberOfLoops = jaggedArray[row].Length >= jaggedArray[row + 1].Length ? jaggedArray[row].Length : jaggedArray[row + 1].Length; 

                for (int col = 0; col < numberOfLoops; col++)
                {
                    if (jaggedArray[row].Length == jaggedArray[row + 1].Length)
                    {
                        jaggedArray[row][col] *= 2;
                        jaggedArray[row + 1][col] *= 2;
                    }
                    else
                    {
                        if (col < jaggedArray[row].Length)
                        {
                            jaggedArray[row][col] /= 2;
                        }
                        
                        if (col < jaggedArray[row + 1].Length)
                        {
                            jaggedArray[row + 1][col] /= 2;
                        }
                    }
                }
            }

            string[] command = Console.ReadLine().Split();

            while (command[0] != "End")
            {
                int row = int.Parse(command[1]);
                int col = int.Parse(command[2]);
                long value = long.Parse(command[3]);

                if (row >= 0 && row < jaggedArray.Length && col >= 0 && col < jaggedArray[row].Length)
                {
                    if (command[0] == "Add")
                    {
                        jaggedArray[row][col] += value;
                    }
                    else if (command[0] == "Subtract")
                    {
                        jaggedArray[row][col] -= value;
                    }
                }

                command = Console.ReadLine().Split();
            }

            foreach (long[] row in jaggedArray)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
