using System;
using System.Linq;

namespace Primary_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());
            int[,] matrix = new int[matrixSize, matrixSize];

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                int[] elements = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToArray();

                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    matrix[r, c] = elements[c];
                }
            }

            int sum = 0;

            for (int r = 0; r < matrixSize; r++)
            {
                for (int c = 0; c < 1; c++)
                {
                    sum += matrix[r, c + r];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
