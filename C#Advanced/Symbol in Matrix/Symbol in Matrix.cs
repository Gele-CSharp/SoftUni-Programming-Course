using System;

namespace Symbol_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());
            char[,] matrix = new char[matrixSize, matrixSize];

            for (int r = 0; r < matrixSize; r++)
            {
                char[] elements = Console.ReadLine().ToCharArray();

                for (int c = 0; c < matrixSize; c++)
                {
                    matrix[r, c] = elements[c];
                }
            }

            char wantedSymbol = char.Parse(Console.ReadLine());

            for (int r = 0; r < matrixSize; r++)
            {
                for (int c = 0; c < matrixSize; c++)
                {
                    if (matrix[r, c] == wantedSymbol)
                    {
                        Console.WriteLine($"({r}, {c})");
                        return;
                    }
                }
            }

            Console.WriteLine($"{wantedSymbol} does not occur in the matrix");
        }
    }
}
