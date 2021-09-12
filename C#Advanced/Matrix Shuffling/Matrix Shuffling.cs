using System;
using System.Linq;

namespace Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine()
                              .Split() 
                              .Select(int.Parse)
                              .ToArray();

            string[,] matrix = new string[matrixSize[0], matrixSize[1]];

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                string[] elements = Console.ReadLine().Split();

                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    matrix[r, c] = elements[c];
                }
            }

            string[] command = Console.ReadLine().Split();

            while (command[0] != "END")
            {
                if (command[0] == "swap" && command.Length == 5)
                {
                    int row = int.Parse(command[1]);
                    int col = int.Parse(command[2]);
                    int rowToSwap = int.Parse(command[3]);
                    int colToSwap = int.Parse(command[4]);

                    if (row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1) 
                        && rowToSwap >= 0 && rowToSwap < matrix.GetLength(0) 
                        && colToSwap >= 0 && colToSwap < matrix.GetLength(1))
                    {
                        string elementToSwap = matrix[row, col];
                        matrix[row, col] = matrix[rowToSwap, colToSwap];
                        matrix[rowToSwap, colToSwap] = elementToSwap;

                        for (int r = 0; r < matrix.GetLength(0); r++)
                        {
                            for (int c = 0; c < matrix.GetLength(1); c++)
                            {
                                Console.Write($"{matrix[r, c]} ");
                            }
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                command = Console.ReadLine().Split();
            }
        }
    }
}
