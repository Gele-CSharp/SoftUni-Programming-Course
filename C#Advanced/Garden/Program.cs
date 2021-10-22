using System;
using System.Collections.Generic;

namespace Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] gardenSize = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int numberOfRows = int.Parse(gardenSize[0]);
            int numberOfCols = int.Parse(gardenSize[1]);
            int[,] garden = new int[numberOfRows, numberOfRows];
            List<int> flowerCoordinates = new List<int>();

            string[] position = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (position[0] != "Bloom")
            {
                int flowerRow = int.Parse(position[0]);
                int flowerCol = int.Parse(position[1]);

                if (flowerRow >= 0 && flowerRow < numberOfRows && flowerCol >= 0 && flowerCol < numberOfCols)
                {
                    garden[flowerRow, flowerCol] = 1;
                    flowerCoordinates.Add(flowerRow);
                    flowerCoordinates.Add(flowerCol);
                }
                else
                {
                    Console.WriteLine("Invalid coordinates.");
                }

                position = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            for (int i = 0; i < flowerCoordinates.Count - 1; i += 2)
            {
                int currentFlowerRow = flowerCoordinates[i];
                int currentFlowerCol = flowerCoordinates[i + 1];

                for (int r = 0; r < numberOfRows; r++)
                {
                    for (int c = 0; c < numberOfCols; c++)
                    {
                        if (r == currentFlowerRow && c == currentFlowerCol)
                        {
                            continue;
                        }
                        else if (r == currentFlowerRow || c == currentFlowerCol)
                        {
                            garden[r, c]++;
                        }
                    }
                }
            }

            for (int r = 0; r < numberOfRows; r++)
            {
                for (int c = 0; c < numberOfCols; c++)
                {
                    Console.Write($"{garden[r, c]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
