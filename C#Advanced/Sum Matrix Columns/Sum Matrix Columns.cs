using System;
using System.Linq;

namespace Sum_Matrix_Columns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine()
                              .Split(", ")
                              .Select(int.Parse)
                              .ToArray();
            int[,] matrix = new int[matrixSize[0], matrixSize[1]];

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                int[] elements = Console.ReadLine()
                                .Split(" ")
                                .Select(int.Parse)
                                .ToArray();

                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    matrix[r, c] = elements[c];
                }
            }

            for (int c = 0; c < matrix.GetLength(1); c++)
            {
                int sum = 0;

                for (int r = 0; r < matrix.GetLength(0); r++)
                {
                    sum += matrix[r, c];
                }

                Console.WriteLine(sum);
            }
        }
    }
}
