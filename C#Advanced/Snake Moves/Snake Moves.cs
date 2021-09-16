using System;
using System.Linq;

namespace Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string snake = Console.ReadLine();
            char[,] matrix = new char[matrixSize[0], matrixSize[1]];
            int index = 0;

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    if(index == snake.Length)
                    {
                        index = 0;
                    }

                    if (r % 2 != 0)
                    {
                        matrix[r, matrix.GetLength(1) - 1 - c] = snake[index];
                    }
                    else
                    {
                        matrix[r, c] = snake[index];
                    }

                    index++;
                }
            }

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    Console.Write($"{matrix[r, c]}");
                }

                Console.WriteLine();
            }
        }
    }
}
