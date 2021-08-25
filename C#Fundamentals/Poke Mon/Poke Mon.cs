using System;

namespace Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            double theHalfOfPokePower = pokePower / 2.0;
            int numberOfTargets = 0;

            while (pokePower >= distance)
            {
                pokePower -= distance;
                numberOfTargets++;

                if (pokePower == theHalfOfPokePower)
                {
                    if (exhaustionFactor >= 1)
                    {
                        pokePower /= exhaustionFactor;
                    }
                }
            }

            Console.WriteLine(pokePower);

            if (numberOfTargets > 0)
            {
                Console.WriteLine(numberOfTargets);
            }
        }
    }
}
