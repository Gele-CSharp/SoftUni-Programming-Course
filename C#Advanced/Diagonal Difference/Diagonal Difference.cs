using System;
using System.Linq;

namespace Diagonal_Difference
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

            int diagonalSum1 = 0;
            int diagonalSum2 = 0;

            for (int r = 0; r < matrixSize; r++)
            {
                for (int c = 0; c < 1; c++)
                {
                    diagonalSum1 += matrix[r, r];
                    diagonalSum2 += matrix[r, matrixSize - r - 1];
                }
            }

            int difference = Math.Abs(diagonalSum1 - diagonalSum2);

            Console.WriteLine(difference);
        }
    }
}
