using System;

namespace Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            string[,] fieid = new string[fieldSize, fieldSize];
            string[] commands = Console.ReadLine().Split();
            long coals = 0;
            int collectedCoals = 0;
            int startRow = -1;
            int startCol = -1;

            for (int r = 0; r < fieldSize; r++)
            {
                string[] elements = Console.ReadLine().Split();

                for (int c = 0; c < fieldSize; c++)
                {
                    fieid[r, c] = elements[c];

                    if (elements[c] == "s")
                    {
                        startRow = r;
                        startCol = c;
                    }
                    else if (elements[c] == "c")
                    {
                        coals++;
                    }
                }
            }

            for (int i = 0; i < commands.Length; i++)
            {
                switch (commands[i])
                {
                    case "up":
                        startRow--;
                        break;
                    case "down":
                        startRow++;
                        break;
                    case "left":
                        startCol--;
                        break;
                    case "right":
                        startCol++;
                        break;
                    default:
                        Console.WriteLine("Invalid command!");
                        break;
                }

                if (startRow >= 0 && startRow < fieldSize && startCol >= 0 && startCol < fieldSize)
                {
                    if (fieid[startRow, startCol] == "c")
                    {
                        collectedCoals++;
                        fieid[startRow, startCol] = "*";
                    }
                    else if (fieid[startRow, startCol] == "e")
                    {
                        Console.WriteLine($"Game over! ({startRow}, {startCol})");
                        return;
                    }
                }
                else 
                {
                    switch (commands[i])
                    {
                        case "up":
                            startRow++;
                            break;
                        case "down":
                            startRow--;
                            break;
                        case "left":
                            startCol++;
                            break;
                        case "right":
                            startCol--;
                            break;
                    }
                }
            }

            if (collectedCoals == coals)
            {
                Console.WriteLine($"You collected all coals! ({startRow}, {startCol})");
            }
            else if (collectedCoals < coals)
            {
                Console.WriteLine($"{coals - collectedCoals} coals left. ({startRow}, {startCol})");
            }
        }
    }
}
