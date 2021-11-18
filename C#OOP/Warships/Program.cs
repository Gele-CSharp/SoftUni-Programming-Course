using System;
using System.Collections.Generic;

namespace Warships
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfField = int.Parse(Console.ReadLine());
            string[,] field = new string[sizeOfField, sizeOfField];
            List<string> commands = new List<string>(Console.ReadLine()
                .Split(",", StringSplitOptions.RemoveEmptyEntries));
            int firstPlayerShips = 0;
            int secondplayerShips = 0;
            bool isDraw = true;

            for (int r = 0; r < field.GetLength(0); r++)
            {
                string[] lineInfo = Console.ReadLine().Split();

                for (int c = 0; c < field.GetLength(1); c++)
                {
                    field[r, c] = lineInfo[c];

                    if (field[r, c] == "<")
                    {
                        firstPlayerShips++;
                    }
                    else if (field[r, c] == ">")
                    {
                        secondplayerShips++;
                    }
                }
            }

            int totalShips = firstPlayerShips + secondplayerShips;

            for (int i = 0; i < commands.Count; i++)
            {
                string[] coordinates = commands[i].Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int row = int.Parse(coordinates[0]);
                int col = int.Parse(coordinates[1]);

                if (row >= 0 && row < sizeOfField && col >= 0 && col < sizeOfField)
                {
                    if (field[row, col] == "<")
                    {
                        firstPlayerShips--;
                        field = OverwritePosition(field, row, col);
                    }
                    else if (field[row, col] == ">")
                    {
                        secondplayerShips--;
                        field = OverwritePosition(field, row, col);
                    }
                    else if (field[row, col] == "#")
                    {
                        field = OverwritePosition(field, row, col);
                        field = MineExplosion(field, row, col);
                        firstPlayerShips = 0;
                        secondplayerShips = 0;

                        foreach (var position in field)
                        {
                            if (position == "<")
                            {
                                firstPlayerShips++;
                            }
                            else if (position == ">")
                            {
                                secondplayerShips++;
                            }
                        }
                    }
                }

                if (firstPlayerShips == 0 || secondplayerShips == 0)
                {
                    isDraw = false;
                    break;
                }
            }

            if(isDraw == false)
            {
                if (firstPlayerShips > 0)
                {
                    Console.WriteLine($"Player One has won the game! {totalShips - (firstPlayerShips + secondplayerShips)} ships have been sunk in the battle.");
                }
                else
                {
                    Console.WriteLine($"Player Two has won the game! {totalShips - (firstPlayerShips + secondplayerShips)} ships have been sunk in the battle.");
                }
            }
            else
            {
                Console.WriteLine($"It's a draw! Player One has {firstPlayerShips} ships left. Player Two has {secondplayerShips} ships left.");
            }
        }

        private static string[,] MineExplosion(string[,] field, int row, int col)
        {
            if (row + 1 >= 0 && row + 1 < field.GetLength(0) && col >= 0 && col < field.GetLength(1))
            {
                row++;
                field = OverwritePosition(field, row, col);
                row--;
            }

            if (row - 1 >= 0 && row - 1 < field.GetLength(0) && col >= 0 && col < field.GetLength(1))
            {
                row--;
                field = OverwritePosition(field, row, col);
                row++;
            }

            if (row >= 0 && row < field.GetLength(0) && col + 1 >= 0 && col + 1 < field.GetLength(1))
            {
                col++;
                field = OverwritePosition(field, row, col);
                col--;
            }

            if (row >= 0 && row < field.GetLength(0) && col - 1 >= 0 && col - 1 < field.GetLength(1))
            {
                col--;
                field = OverwritePosition(field, row, col);
                col++;
            }

            if (row + 1 >= 0 && row + 1 < field.GetLength(0) && col + 1 >= 0 && col + 1 < field.GetLength(1))
            {
                row++;
                col++;
                field = OverwritePosition(field, row, col);
                row--;
                col--;
            }

            if (row + 1 >= 0 && row + 1 < field.GetLength(0) && col - 1 >= 0 && col - 1 < field.GetLength(1))
            {
                row++;
                col--;
                field = OverwritePosition(field, row, col);
                row--;
                col++;
            }

            if (row - 1 >= 0 && row - 1 < field.GetLength(0) && col + 1 >= 0 && col + 1 < field.GetLength(1))
            {
                row--;
                col++;
                field = OverwritePosition(field, row, col);
                row++;
                col--;
            }

            if (row - 1 >= 0 && row - 1 < field.GetLength(0) && col - 1 >= 0 && col - 1 < field.GetLength(1))
            {
                row--;
                col--;
                field = OverwritePosition(field, row, col);
                row++;
                col++;
            }

            return field;
        }

        public static string[,] OverwritePosition(string[,] field, int row, int col)
        {
            if (field[row, col] != "*")
            {
                field[row, col] = "X";
            }
            
            return field;
        }
    }
}
