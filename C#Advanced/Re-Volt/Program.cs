using System;

namespace Re_Volt
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int numberOfCommands = int.Parse(Console.ReadLine());
            string[,] field = new string[size, size];
            int playerRowPosition = -1;
            int playerColPosition = -1;

            for (int r = 0; r < size; r++)
            {
                string rowInfo = Console.ReadLine();

                for (int c = 0; c < size; c++)
                {
                    field[r, c] = rowInfo[c].ToString();

                    if (field[r, c] == "f")
                    {
                        playerRowPosition = r;
                        playerColPosition = c;
                    }
                }
            }

            bool isWon = false;

            for (int i = 0; i < numberOfCommands; i++)
            {
                int lastPlayerRow = playerRowPosition;
                int lastPlayerCol = playerColPosition;
                string command = Console.ReadLine();

                int[] position = Move(field, command, playerRowPosition, playerColPosition);
                playerRowPosition = position[0];
                playerColPosition = position[1];

                if (field[playerRowPosition, playerColPosition] == "B")
                {
                    position = Move(field, command, playerRowPosition, playerColPosition);
                    playerRowPosition = position[0];
                    playerColPosition = position[1];
                }
                
                if (field[playerRowPosition, playerColPosition] == "-")
                {
                    MakeStep(field, playerRowPosition, playerColPosition, lastPlayerRow, lastPlayerCol);
                }
                else if (field[playerRowPosition, playerColPosition] == "F")
                {
                    MakeStep(field, playerRowPosition, playerColPosition, lastPlayerRow, lastPlayerCol);
                    Console.WriteLine("Player won!");
                    isWon = true;
                    break;
                }
                else if (field[playerRowPosition, playerColPosition] == "T")
                {
                    playerRowPosition = lastPlayerRow;
                    playerColPosition = lastPlayerCol;
                }
            }

            if (isWon == false)
            {
                Console.WriteLine("Player lost!");
            }

            for (int r = 0; r < size; r++)
            {
                for (int c = 0; c < size; c++)
                {
                    Console.Write(field[r, c]);
                }
                Console.WriteLine();
            }
        }

        public static int[] Move(string[,] field, string command, int playerRowPosition, int playerColPosition)
        {
            switch (command)
            {
                case "up":
                    playerRowPosition--;
                    break;
                case "down":
                    playerRowPosition++;
                    break;
                case "right":
                    playerColPosition++;
                    break;
                case "left":
                    playerColPosition--;
                    break;
            }

            if (playerRowPosition < 0)
            {
                playerRowPosition = field.GetLength(0) - 1;
            }
            else if (playerRowPosition >= field.GetLength(0))
            {
                playerRowPosition = 0;
            }
            else if (playerColPosition < 0)
            {
                playerColPosition = field.GetLength(0) - 1;
            }
            else if (playerColPosition >= field.GetLength(0))
            {
                playerColPosition = 0;
            }

            int[] position = new int[2];
            position[0] = playerRowPosition;
            position[1] = playerColPosition;
            return position;
        }

        public static void MakeStep(string[,] field, int playerRowPosition, int playerColPosition, int lastPlayerRow, int lastPlayerCol)
        {
            if(field[playerRowPosition, playerColPosition] != "B" && field[playerRowPosition, playerColPosition] != "T")
            {
                field[playerRowPosition, playerColPosition] = "f";
            }
            field[lastPlayerRow, lastPlayerCol] = "-";
        }
    }
}
