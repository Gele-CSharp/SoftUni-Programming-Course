using System;

namespace MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            int health = 100;
            int bitcoins = 0;
            string[] dungeonRooms = Console.ReadLine().Split('|');

            for (int i = 0; i < dungeonRooms.Length; i++)
            {
                string[] commandAndNumber = dungeonRooms[i].Split();
                string command = commandAndNumber[0];
                int number = int.Parse(commandAndNumber[1]);

                if (command == "potion")
                {
                    health += number;

                    if (health > 100)
                    {
                        Console.WriteLine($"You healed for {100 - (health - number)} hp.");
                        health = 100;
                    }
                    else
                    {
                        Console.WriteLine($"You healed for {number} hp.");
                    }

                    Console.WriteLine($"Current health: {health} hp.");
                }
                else if (command == "chest")
                {
                    Console.WriteLine($"You found {number} bitcoins.");
                    bitcoins += number;
                }
                else
                {
                    health -= number;
                    string monster = command;

                    if (health > 0)
                    {
                        Console.WriteLine($"You slayed {monster}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {monster}.");
                        Console.WriteLine($"Best room: {i + 1}");
                        return;
                    }
                }
            }

            Console.WriteLine("You've made it!");
            Console.WriteLine($"Bitcoins: {bitcoins}");
            Console.WriteLine($"Health: {health}");
        }
    }
}
