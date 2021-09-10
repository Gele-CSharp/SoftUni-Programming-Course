using System;
using System.Linq;

namespace Jagged_Array_Modification
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

            string[] command = Console.ReadLine().Split();

            while (command[0] != "END")
            {
                int row = int.Parse(command[1]);
                int col = int.Parse(command[2]);
                int value = int.Parse(command[3]);

                if (row < 0 || row >= matrix.GetLength(0) || col < 0 || col >= matrix.GetLength(1))
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else if (command[0] == "Add")
                {
                    matrix[row, col] += value;
                }
                else if (command[0] == "Subtract")
                {
                    matrix[row, col] -= value;
                }

                command = Console.ReadLine().Split();
            }

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    Console.Write($"{matrix[r, c]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
