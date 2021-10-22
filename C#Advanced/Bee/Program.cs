using System;

namespace Bee
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string[,] beeTerritory = new string[size, size];
            int polinatedFlowers = 0;
            int beeRow = -1;
            int beeCol = -1;

            for (int r = 0; r < size; r++)
            {
                string rowInfo = Console.ReadLine();

                for (int c = 0; c < size; c++)
                {
                    beeTerritory[r, c] = rowInfo[c].ToString();

                    if (beeTerritory[r, c] == "B")
                    {
                        beeRow = r;
                        beeCol = c;
                    }
                }
            }

            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                beeTerritory[beeRow, beeCol] = ".";

                switch (command)
                {
                    case "up":
                        beeRow--;
                        break;
                    case "down":
                        beeRow++;
                        break;
                    case "right":
                        beeCol++;
                        break;
                    case "left":
                        beeCol--;
                        break;
                }

                if (beeRow >= 0 && beeRow < size && beeCol >= 0 && beeCol < size)
                {
                    if (beeTerritory[beeRow, beeCol] == "f")
                    {
                        polinatedFlowers++;
                        beeTerritory[beeRow, beeCol] = "B";
                    }
                    else if (beeTerritory[beeRow, beeCol] == "O")
                    {
                        beeTerritory[beeRow, beeCol] = ".";

                        switch (command)
                        {
                            case "up":
                                beeRow--;
                                break;
                            case "down":
                                beeRow++;
                                break;
                            case "right":
                                beeCol++;
                                break;
                            case "left":
                                beeCol--;
                                break;
                        }

                        if (beeTerritory[beeRow, beeCol] == "f")
                        {
                            polinatedFlowers++;
                        }

                        beeTerritory[beeRow, beeCol] = "B";
                    }
                }
                else
                {
                    Console.WriteLine("The bee got lost!");
                    break;
                }
            }

            if (polinatedFlowers >= 5)
            {
                Console.WriteLine($"Great job, the bee managed to pollinate {polinatedFlowers} flowers!");
            }
            else
            {
                Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {5 - polinatedFlowers} flowers more");
            }

            for (int r = 0; r < size; r++)
            {
                for (int c = 0; c < size; c++)
                {
                    Console.Write(beeTerritory[r,c]);
                }
                Console.WriteLine();
            }
        }
    }
}
