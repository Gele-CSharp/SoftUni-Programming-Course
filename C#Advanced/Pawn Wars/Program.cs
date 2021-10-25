using System;
using System.IO;

namespace Pawn_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] chessBoard = new string[8, 8];
            int whitePawnRow = -1;
            int whitePawnCol = -1;
            int blackPawnRow = -1;
            int blackPawnCol = -1;

            for (int r = 0; r < 8; r++)
            {
                string rowInfo = Console.ReadLine();

                for (int c = 0; c < 8; c++)
                {
                    chessBoard[r, c] = rowInfo[c].ToString();

                    if (chessBoard[r, c] == "w")
                    {
                        whitePawnRow = r;
                        whitePawnCol = c;
                    }
                    else if (chessBoard[r, c] == "b")
                    {
                        blackPawnRow = r;
                        blackPawnCol = c;
                    }
                }
            }


            int numberOfMove = 0;

            while (true)
            {
                if (numberOfMove % 2 == 0)
                {
                    chessBoard[whitePawnRow, whitePawnCol] = "-";
                    whitePawnRow--;

                    if (whitePawnRow > 0)
                    {
                        if (IsThereCapture(chessBoard, whitePawnRow, whitePawnCol))
                        {
                            Console.WriteLine($"Game over! White capture on {Convert.ToChar(blackPawnCol + 97)}{8 - blackPawnRow}.");
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Game over! White pawn is promoted to a queen at {Convert.ToChar(whitePawnCol + 97)}{8 - whitePawnRow}.");
                        return;
                    }

                    chessBoard[whitePawnRow, whitePawnCol] = "w";

                }
                else
                {
                    chessBoard[blackPawnRow, blackPawnCol] = "-";
                    blackPawnRow++;

                    if (blackPawnRow < 7)
                    {
                        if (IsThereCapture(chessBoard, blackPawnRow, blackPawnCol))
                        {
                            Console.WriteLine($"Game over! Black capture on {Convert.ToChar(whitePawnCol + 97)}{8 - whitePawnRow}.");
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Game over! Black pawn is promoted to a queen at {Convert.ToChar(blackPawnCol + 97)}{8 - blackPawnRow}.");
                        return;
                    }

                    chessBoard[blackPawnRow, blackPawnCol] = "b";
                }

                numberOfMove++;
            }
        }

        public static bool IsThereCapture(string[,] chessBoard, int row, int col)
        {
            if (col + 1 <= 7)
            {
                if (chessBoard[row, col + 1] == "b" || chessBoard[row, col + 1] == "w")
                {
                    return true;
                }
            }

            if (col - 1 >= 0)
            {
                if (chessBoard[row, col - 1] == "w" || chessBoard[row, col - 1] == "b")
                {
                    return true;
                }
            }

            return false;
        }
    }
}
