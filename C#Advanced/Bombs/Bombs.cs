using System;
using System.Linq;

namespace Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());
            int[,] matrix = new int[matrixSize, matrixSize];

            for (int r = 0; r < matrixSize; r++)
            {

                int[] elements = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToArray();

                for (int c = 0; c < matrixSize; c++)
                {
                    matrix[r, c] = elements[c];
                }
            }

            string[] coordinates = Console.ReadLine().Split();

            for (int i = 0; i < coordinates.Length; i++)
            {
                string[] currentBombCoordinates = coordinates[i].Split(',');
                int bombRow = int.Parse(currentBombCoordinates[0]);
                int bombCol = int.Parse(currentBombCoordinates[1]);

                if (bombRow >= 0 && bombRow < matrix.GetLength(0) && bombCol >= 0 && bombCol < matrix.GetLength(1))
                {
                    int value = matrix[bombRow, bombCol];
                    matrix[bombRow, bombCol] -= value;

                    if (bombRow + 1 >= 0 && bombRow + 1 < matrix.GetLength(0))
                    {
                        if (matrix[bombRow + 1, bombCol] > 0)
                        {
                            matrix[bombRow + 1, bombCol] -= value;
                        }
                    }

                    if (bombRow - 1 >= 0 && bombRow - 1 < matrix.GetLength(0))
                    {
                        if (matrix[bombRow - 1, bombCol] > 0)
                        {
                            matrix[bombRow - 1, bombCol] -= value;
                        }
                    }

                    if (bombRow + 1 >= 0 && bombRow + 1 < matrix.GetLength(0) && bombCol + 1 >= 0 && bombCol + 1 < matrix.GetLength(1))
                    {
                        if (matrix[bombRow + 1, bombCol + 1] > 0)
                        {
                            matrix[bombRow + 1, bombCol + 1] -= value;
                        }
                    }

                    if (bombRow + 1 >= 0 && bombRow + 1 < matrix.GetLength(0) && bombCol - 1 >= 0 && bombCol - 1 < matrix.GetLength(1))
                    {
                        if (matrix[bombRow + 1, bombCol - 1] > 0)
                        {
                            matrix[bombRow + 1, bombCol - 1] -= value;
                        }
                    }

                    if (bombRow - 1 >= 0 && bombRow - 1 < matrix.GetLength(0) && bombCol + 1 >= 0 && bombCol + 1 < matrix.GetLength(1))
                    {
                        if (matrix[bombRow - 1, bombCol + 1] > 0)
                        {
                            matrix[bombRow - 1, bombCol + 1] -= value;
                        }
                    }

                    if (bombRow - 1 >= 0 && bombRow - 1 < matrix.GetLength(0) && bombCol - 1 >= 0 && bombCol - 1 < matrix.GetLength(1))
                    {
                        if (matrix[bombRow - 1, bombCol - 1] > 0)
                        {
                            matrix[bombRow - 1, bombCol - 1] -= value;
                        }
                    }

                    if (bombCol + 1 >= 0 && bombCol + 1 < matrix.GetLength(1))
                    {
                        if (matrix[bombRow, bombCol + 1] > 0)
                        {
                            matrix[bombRow, bombCol + 1] -= value;
                        }
                    }

                    if (bombCol - 1 >= 0 && bombCol - 1 < matrix.GetLength(1))
                    {
                        if (matrix[bombRow, bombCol - 1] > 0)
                        {
                            matrix[bombRow, bombCol - 1] -= value;
                        }
                    }
                }
            }

            int sum = 0;
            int aliveElements = 0;

            foreach (int element in matrix)
            {
                if (element > 0)
                {
                    sum += element;
                    aliveElements++;
                }
            }

            Console.WriteLine($"Alive cells: {aliveElements}");
            Console.WriteLine($"Sum: {sum}");

            for (int r = 0; r < matrixSize; r++)
            {
                for (int c = 0; c < matrixSize; c++)
                {
                    Console.Write($"{matrix[r, c]} ");
                }

                Console.WriteLine();
            }
        }
    }
}
