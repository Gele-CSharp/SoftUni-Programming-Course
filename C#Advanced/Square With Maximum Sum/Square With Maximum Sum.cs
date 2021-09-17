using System;
using System.Linq;

namespace Square_With_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSizes = Console.ReadLine()
                                .Split(", ")
                                .Select(int.Parse)
                                .ToArray();

            int[,] matrix = new int[matrixSizes[0], matrixSizes[1]];

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                int[] elements = Console.ReadLine()
                                .Split(", ")
                                .Select(int.Parse)
                                .ToArray();

                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    matrix[r, c] = elements[c];
                }
            }

            int maxSumSubmatrix = int.MinValue;
            int maxSumRow = -1;
            int maxSumCol = -1;

            for (int r = 0; r < matrix.GetLength(0) - 1; r++)
            {
                for (int c = 0; c < matrix.GetLength(1) - 1; c++)
                {
                    int submatrixSum = 0;
                    submatrixSum += matrix[r, c];
                    submatrixSum += matrix[r, c + 1];
                    submatrixSum += matrix[r + 1, c];
                    submatrixSum += matrix[r + 1, c + 1];

                    if (submatrixSum > maxSumSubmatrix)
                    {
                        maxSumSubmatrix = submatrixSum;
                        maxSumRow = r;
                        maxSumCol = c;
                    }
                }
            }

            Console.WriteLine($"{matrix[maxSumRow, maxSumCol]} {matrix[maxSumRow, maxSumCol + 1]}");
            Console.WriteLine($"{matrix[maxSumRow + 1, maxSumCol]} {matrix[maxSumRow + 1, maxSumCol + 1]}");
            Console.WriteLine(maxSumSubmatrix);
        }
    }
}
