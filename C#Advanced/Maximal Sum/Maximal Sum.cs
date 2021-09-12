using System;
using System.Linq;

namespace Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine()
                             .Split()
                             .Select(int.Parse)
                             .ToArray();

            //if (matrixSize[0] >= 3 && matrixSize[1] >= 3)
            {
                long[,] matrix = new long[matrixSize[0], matrixSize[1]];

                for (long r = 0; r < matrix.GetLength(0); r++)
                {
                    long[] elements = Console.ReadLine()
                                    .Split()
                                    .Select(long.Parse)
                                    .ToArray();

                    for (long c = 0; c < matrix.GetLength(1); c++)
                    {
                        matrix[r, c] = elements[c];
                    }
                }

                long maxSubmatrixSum = long.MinValue;
                long maxSubmatrixSumRow = -1;
                long maxSubmatrixSumCol = -1;

                for (long r = 0; r < matrix.GetLength(0) - 2; r++)
                {
                    for (long c = 0; c < matrix.GetLength(1) - 2; c++)
                    {
                        long sum = 0;
                        sum += matrix[r, c];
                        sum += matrix[r, c + 1];
                        sum += matrix[r, c + 2];
                        sum += matrix[r + 1, c];
                        sum += matrix[r + 1, c + 1];
                        sum += matrix[r + 1, c + 2];
                        sum += matrix[r + 2, c];
                        sum += matrix[r + 2, c + 1];
                        sum += matrix[r + 2, c + 2];

                        if (sum > maxSubmatrixSum)
                        {
                            maxSubmatrixSum = sum;
                            maxSubmatrixSumRow = r;
                            maxSubmatrixSumCol = c;
                        }
                    }
                }

                if (maxSubmatrixSum > long.MinValue)
                {
                    Console.WriteLine($"Sum = {maxSubmatrixSum}");
                    Console.WriteLine($"{matrix[maxSubmatrixSumRow, maxSubmatrixSumCol]} " +
                                      $"{matrix[maxSubmatrixSumRow, maxSubmatrixSumCol + 1]} " +
                                      $"{matrix[maxSubmatrixSumRow, maxSubmatrixSumCol + 2]}");
                    Console.WriteLine($"{matrix[maxSubmatrixSumRow + 1, maxSubmatrixSumCol]} " +
                                      $"{matrix[maxSubmatrixSumRow + 1, maxSubmatrixSumCol + 1]} " +
                                      $"{matrix[maxSubmatrixSumRow + 1, maxSubmatrixSumCol + 2]}");
                    Console.WriteLine($"{matrix[maxSubmatrixSumRow + 2, maxSubmatrixSumCol]} " +
                                      $"{matrix[maxSubmatrixSumRow + 2, maxSubmatrixSumCol + 1]} " +
                                      $"{matrix[maxSubmatrixSumRow + 2, maxSubmatrixSumCol + 2]}");
                }
            }
        }
    }
}
