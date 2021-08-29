using System;
using System.Collections.Generic;
using System.Linq;

namespace The_Pianist
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPieces = int.Parse(Console.ReadLine());
            var pieces = new Dictionary<string, string>();
            var composers = new Dictionary<string, string>();

            for (int i = 0; i < numberOfPieces; i++)
            {
                string[] pieceInfo = Console.ReadLine().Split('|');

                string piece = pieceInfo[0];
                string composer = pieceInfo[1];
                string key = pieceInfo[2];

                pieces.Add(piece, key);
                composers.Add(piece, composer);
            }

            string[] command = Console.ReadLine().Split('|');

            while (command[0] != "Stop")
            {
                string piece = command[1];

                if (command[0] == "Add")
                {
                    string composer = command[2];
                    string key = command[3];
                    
                    if (pieces.ContainsKey(piece) == false)
                    {
                        pieces.Add(piece, key);
                        composers.Add(piece, composer);
                        Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                    }
                    else
                    {
                        Console.WriteLine($"{piece} is already in the collection!");
                    }
                }
                else if (command[0] == "Remove")
                {
                    if (pieces.ContainsKey(piece))
                    {
                        pieces.Remove(piece);
                        composers.Remove(piece);
                        Console.WriteLine($"Successfully removed {piece}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
                else if (command[0] == "ChangeKey")
                {
                    string newKey = command[2];

                    if (pieces.ContainsKey(piece))
                    {
                        pieces[piece] = newKey;
                        Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }

                command = Console.ReadLine().Split('|');
            }

            foreach (var piece in pieces.OrderBy(p=>p.Key))
            {
                foreach (var composer in composers.OrderBy(c=>c.Value).Where(c=>c.Key == piece.Key))
                {
                    Console.WriteLine($"{piece.Key} -> Composer: {composer.Value}, Key: {piece.Value}");
                }
            }
        }
    }
}
