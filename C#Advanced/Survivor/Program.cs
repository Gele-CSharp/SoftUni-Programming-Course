using System;

namespace Survivor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfRows = int.Parse(Console.ReadLine());
            string[][] beach = new string[numberOfRows][];

            for (int i = 0; i < numberOfRows; i++)
            {
                string[] rowInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                beach[i] = rowInfo;
            }

            string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Player player = new Player();
            Player opponent = new Player();

            while (command[0] != "Gong")
            {
                int row = int.Parse(command[1]);
                int col = int.Parse(command[2]);

                if (command[0] == "Find")
                {
                    //if (row >= 0 && row < numberOfRows && col >= 0 && col < beach[row].Length)
                    //{
                    //    if (beach[row][col] == "T")
                    //    {
                    //        collectedTokens++;
                    //        beach[row][col] = "-";
                    //    }
                    //}
                    //else if (command[0] == "Opponent")
                    //{
                    //    string direction = command[3];

                    //    if(row >= 0 && row < numberOfRows && col >= 0 && col < beach[row].Length)
                    //    {
                    //        if ()
                    //    }
                    //}

                    player.CollectToken(beach, row, col);
                }
                else if (command[0] == "Opponent")
                {
                    string direction = command[3];

                    for (int i = 0; i <= 3; i++)
                    {
                        opponent.CollectToken(beach, row, col);

                        switch (direction)
                        {
                            case "up": row--;
                                break;
                            case "down": row++;
                                break;
                            case "right": col++;
                                break;
                            case "left": col--;
                                break;
                        }
                    }
                }

                command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            for (int row = 0; row < numberOfRows; row++)
            {
                for (int col = 0; col < beach[row].Length; col++)
                {
                    Console.Write(beach[row][col] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Collected tokens: {player.NumberOfTokens}");
            Console.WriteLine($"Opponent's tokens: {opponent.NumberOfTokens}");
        }
    }

    public class Player
    {
        public int NumberOfTokens { get; set; }

        public  void CollectToken(string[][] field, int row, int col)
        {
            if (row >= 0 && row < field.GetLength(0) && col >= 0 && col < field[row].Length)
            {
                if (field[row][col] == "T")
                {
                    this.NumberOfTokens++;
                    field[row][col] = "-";
                }
            }
        }
    }
}
