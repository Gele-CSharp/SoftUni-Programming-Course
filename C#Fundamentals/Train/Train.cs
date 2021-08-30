using System;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfWagons = int.Parse(Console.ReadLine());
            int[] people = new int[numberOfWagons];
            int sum = 0;

            for (int i = 0; i < numberOfWagons; i++)
            {
                people[i] = int.Parse(Console.ReadLine());
            }

            foreach (int peoplePerWagon in people)
            {
                Console.Write($"{peoplePerWagon} ");
                sum += peoplePerWagon;
            }

            Console.WriteLine();

            Console.WriteLine(sum);
        }
    }
}
