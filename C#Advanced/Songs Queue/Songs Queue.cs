using System;
using System.Collections.Generic;

namespace Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            Queue<string> listOfSongs = new Queue<string>(songs);

            string[] command = Console.ReadLine().Split();

            while (listOfSongs.Count > 0)
            {
                if (command[0] == "Play")
                {
                    if (listOfSongs.Count > 0)
                    {
                        listOfSongs.Dequeue();
                    }
                }
                else if (command[0] == "Add")
                {
                    string song = string.Join(" ", command).Substring(4);

                    if (listOfSongs.Contains(song) == false)
                    {
                        listOfSongs.Enqueue(song);
                    }
                    else
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                }
                else if (command[0] == "Show")
                {
                    if (listOfSongs.Count > 0)
                    {
                        Console.Write(string.Join(", ", listOfSongs));
                        Console.WriteLine();
                    }
                }

                if (listOfSongs.Count == 0)
                {
                    break;
                }

                command = Console.ReadLine().Split();
            }

            Console.WriteLine("No more songs!");
        }
    }
}
