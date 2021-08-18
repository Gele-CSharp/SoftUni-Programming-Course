using System;

namespace Counter_Strike
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int wonBattles = 0;

            while (command != "End of battle")
            {
                int distanceToEnemy = int.Parse(command);

                if (energy - distanceToEnemy >= 0)
                {
                    wonBattles++;
                    energy -= distanceToEnemy;

                    if (wonBattles % 3 == 0)
                    {
                        energy += wonBattles;
                    }
                }
                else
                {
                    Console.WriteLine($"Not enough energy! Game ends with {wonBattles} won battles and {energy} energy");
                    return;
                }


                command = Console.ReadLine();
            }

            Console.WriteLine($"Won battles: {wonBattles}. Energy left: {energy}");
        }
    }
}
