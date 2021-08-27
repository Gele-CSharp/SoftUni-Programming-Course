using System;
using System.Linq;

namespace Shoot_for_the_Win
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string command = Console.ReadLine();
            int numberOfShotTargets = 0;

            while (command != "End")
            {
                int indexOfTargetToShoot = int.Parse(command);

                if (indexOfTargetToShoot >= targets.Length || indexOfTargetToShoot < 0)
                {
                    command = Console.ReadLine();
                    continue;
                }
                else
                {
                    int valueOfTarget = targets[indexOfTargetToShoot];
                    numberOfShotTargets++;

                    for (int i = 0; i < targets.Length; i++)
                    {
                        targets[indexOfTargetToShoot] = -1;

                        if (targets[i] > valueOfTarget && targets[i] != -1)
                        {
                            targets[i] -= valueOfTarget;
                        }
                        else if (targets[i] <= valueOfTarget && targets[i] != -1)
                        {
                            targets[i] += valueOfTarget;
                        }
                    }
                }

                command = Console.ReadLine();
            }

            Console.Write($"Shot targets: {numberOfShotTargets} -> {string.Join(" ", targets)}");
            Console.WriteLine();
        }
    }
}
