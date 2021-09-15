using System;
using System.Collections.Generic;
using System.Linq;

namespace Radioactive_Mutant_Vampire_Bunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lairSize = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[,] lair = new string[lairSize[0], lairSize[1]];
            int playerPositionRow = -1;
            int playerPositionCol = -1;
            bool isDead = false;
            bool isWon = false;
            int startRow = -1;
            int startCol = -1;

            for (int r = 0; r < lair.GetLength(0); r++)
            {
                string elements = Console.ReadLine();

                for (int c = 0; c < lair.GetLength(1); c++)
                {
                    lair[r, c] = elements[c].ToString();

                    if (lair[r, c] == "P")
                    {
                        startRow = r;
                        startCol = c;
                    }
                }
            }

            char[] commands = Console.ReadLine().ToCharArray();

            for (int i = 0; i < commands.Length; i++)
            {
                lair[startRow, startCol] = ".";
                playerPositionRow = startRow;
                playerPositionCol = startCol;

                switch (commands[i])
                {
                    case 'U':
                        startRow--;
                        break;
                    case 'D':
                        startRow++;
                        break;
                    case 'L':
                        startCol--;
                        break;
                    case 'R':
                        startCol++;
                        break;
                }

                if (startRow >= 0 && startRow < lair.GetLength(0) && startCol >= 0 && startCol < lair.GetLength(1))
                {
                    if (lair[startRow, startCol] == "B")
                    {
                        isDead = true;
                    }
                    else
                    {
                        lair[startRow, startCol] = "P";
                    }
                }
                else
                {
                    isWon = true;
                }

                List<int> bunniesCoordinates = new List<int>();

                for (int r = 0; r < lair.GetLength(0); r++)
                {
                    for (int c = 0; c < lair.GetLength(1); c++)
                    {
                        if (lair[r, c] == "B")
                        {
                            bunniesCoordinates.Add(r);
                            bunniesCoordinates.Add(c);
                        }
                    }
                }

                for (int j = 0; j < bunniesCoordinates.Count - 1; j += 2)
                {
                    int r = bunniesCoordinates[j];
                    int c = bunniesCoordinates[j + 1];

                    if (r - 1 >= 0 && r - 1 < lair.GetLength(0))
                    {
                        if (lair[r - 1, c] == "P")
                        {
                            isDead = true;
                            lair[r - 1, c] = "B";
                        }

                        lair[r - 1, c] = "B";
                    }

                    if (r + 1 >= 0 && r + 1 < lair.GetLength(0))
                    {
                        if (lair[r + 1, c] == "P")
                        {
                            isDead = true;
                            lair[r + 1, c] = "B";
                        }

                        lair[r + 1, c] = "B";
                    }

                    if (c + 1 >= 0 && c + 1 < lair.GetLength(1))
                    {
                        if (lair[r, c + 1] == "P")
                        {
                            isDead = true;
                            lair[r, c + 1] = "B";
                        }

                        lair[r, c + 1] = "B";
                    }

                    if (c - 1 >= 0 && c - 1 < lair.GetLength(1))
                    {
                        if (lair[r, c - 1] == "P")
                        {
                            isDead = true;
                            lair[r, c - 1] = "B";
                        }

                        lair[r, c - 1] = "B";
                    }
                }

                if (isWon || isDead)
                {
                    break;
                }
            }

            for (int r = 0; r < lair.GetLength(0); r++)
            {
                for (int c = 0; c < lair.GetLength(1); c++)
                {
                    Console.Write($"{lair[r, c]}");
                }

                Console.WriteLine();
            }

            if (isWon)
            {
                Console.WriteLine($"won: {playerPositionRow} {playerPositionCol}");
            }
            else
            {
                Console.WriteLine($"dead: {startRow} {startCol}");
            }
        }
    }
}
