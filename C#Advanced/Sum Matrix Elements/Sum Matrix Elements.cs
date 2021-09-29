using System;
using System.Linq;

namespace Sum_Matrix_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int numberOfRows = matrixSize[0];
            int numberOfCols = matrixSize[1];
            int[,] matrix = new int[numberOfRows, numberOfCols];
            int sum = 0;

            for (int row = 0; row < numberOfRows; row++)
            {
                int[] elements = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int col = 0; col < numberOfCols; col++)
                {
                    matrix[row, col] = elements[col];
                    sum += elements[col];
                }
            }

            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine(sum);
        }
    }
}
