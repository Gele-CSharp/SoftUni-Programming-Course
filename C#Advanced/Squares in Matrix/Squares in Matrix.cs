using System;
using System.Linq;

namespace Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] matrixSize = Console.ReadLine()
                              .Split()
                              .Select(long.Parse)
                              .ToArray();
            if (matrixSize[0] > 0 && matrixSize[1] > 0)
            {
                char[,] matrix = new char[matrixSize[0], matrixSize[1]];

                for (long r = 0; r < matrix.GetLength(0); r++)
                {
                    char[] elements = Console.ReadLine()
                                     .Split()
                                     .Select(char.Parse)
                                     .ToArray();

                    for (long c = 0; c < matrix.GetLength(1); c++)
                    {
                        matrix[r, c] = elements[c];
                    }
                }

                long numberOfEqualCells = 0;

                for (long r = 0; r < matrix.GetLength(0) - 1; r++)
                {
                    for (long c = 0; c < matrix.GetLength(1) - 1; c++)
                    {
                        char currentElement = matrix[r, c];

                        if (matrix[r, c + 1] == currentElement
                            && matrix[r + 1, c] == currentElement
                            && matrix[r + 1, c + 1] == currentElement)
                        {
                            numberOfEqualCells++;
                        }
                    }
                }

                Console.WriteLine(numberOfEqualCells);
            }
        }
    }
}
