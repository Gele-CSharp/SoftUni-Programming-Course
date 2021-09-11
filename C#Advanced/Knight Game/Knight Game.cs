using System;

namespace Knight_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());
            string[,] chessboard = new string[matrixSize, matrixSize];

            for (int r = 0; r < matrixSize; r++)
            {
                char[] elements = Console.ReadLine().ToCharArray();

                for (int c = 0; c < matrixSize; c++)
                {
                    chessboard[r, c] = elements[c].ToString();
                }
            }

            int knightsToRemove = 0;
            int mostConflictedKnight = -1;

            while (mostConflictedKnight < 0) 
            {
                int mostConflictedRow = -1;
                int mostConflictedCol = -1;

                for (int r = 0; r < matrixSize; r++)
                {
                    for (int c = 0; c < matrixSize; c++)
                    {
                        int numberOfConflicts = FindNumberOfConflicts(chessboard, r, c);

                        if (numberOfConflicts > mostConflictedKnight)
                        {
                            mostConflictedKnight = numberOfConflicts;
                            mostConflictedRow = r;
                            mostConflictedCol = c;
                        }
                    }
                }

                if (mostConflictedKnight > 0)
                {
                    chessboard[mostConflictedRow, mostConflictedCol] = "0";
                    mostConflictedKnight = -1;
                    knightsToRemove++;
                }
            }

            Console.WriteLine(knightsToRemove);
        }

        public static int FindNumberOfConflicts(string[,] chessboard, int r, int c)
        {
            int numberOfConflicts = 0;

            if (chessboard[r, c] == "K")
            {
                if (r + 2 >= 0 && r + 2 < chessboard.GetLength(0) && c + 1 >= 0 && c + 1 < chessboard.GetLength(1))
                {
                    if (chessboard[r, c] == chessboard[r + 2, c + 1])
                    {
                        numberOfConflicts++;
                    }
                }

                if (r + 2 >= 0 && r + 2 < chessboard.GetLength(0) && c - 1 >= 0 && c - 1 < chessboard.GetLength(1))
                {
                    if (chessboard[r, c] == chessboard[r + 2, c - 1])
                    {
                        numberOfConflicts++;
                    }
                }

                if (r + 1 >= 0 && r + 1 < chessboard.GetLength(0) && c - 2 >= 0 && c - 2 < chessboard.GetLength(1))
                {
                    if (chessboard[r, c] == chessboard[r + 1, c - 2])
                    {
                        numberOfConflicts++;
                    }
                }

                if (r + 1 >= 0 && r + 1 < chessboard.GetLength(0) && c + 2 >= 0 && c + 2 < chessboard.GetLength(1))
                {
                    if (chessboard[r, c] == chessboard[r + 1, c + 2])
                    {
                        numberOfConflicts++;
                    }
                }

                if (r - 1 >= 0 && r - 1 < chessboard.GetLength(0) && c - 2 >= 0 && c - 2 < chessboard.GetLength(1))
                {
                    if (chessboard[r, c] == chessboard[r - 1, c - 2])
                    {
                        numberOfConflicts++;
                    }
                }

                if (r - 1 >= 0 && r - 1 < chessboard.GetLength(0) && c + 2 >= 0 && c + 2 < chessboard.GetLength(1))
                {
                    if (chessboard[r, c] == chessboard[r - 1, c + 2])
                    {
                        numberOfConflicts++;
                    }
                }

                if (r - 2 >= 0 && r - 2 < chessboard.GetLength(0) && c - 1 >= 0 && c - 1 < chessboard.GetLength(1))
                {
                    if (chessboard[r, c] == chessboard[r - 2, c - 1])
                    {
                        numberOfConflicts++;
                    }
                }

                if (r - 2 >= 0 && r - 2 < chessboard.GetLength(0) && c + 1 >= 0 && c + 1 < chessboard.GetLength(1))
                {
                    if (chessboard[r, c] == chessboard[r - 2, c + 1])
                    {
                        numberOfConflicts++;
                    }
                }
            }

            return numberOfConflicts;
        }
    }
}
