using System;
using System.Collections.Generic;
using System.Linq;

namespace Filter_By_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            Func<(string name, int age), int, bool> younger = (person, age) => person.age < age;
            Func<(string name, int age), int, bool> older = (person, age) => person.age >= age;
            List<(string, int)> people = new List<(string, int)>();

            for (int i = 0; i < numberOfLines; i++)
            {
                string[] line = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);

                string name = line[0];
                int age = int.Parse(line[1]);
                people.Add((name, age));
            }

            string condition = Console.ReadLine();
            int ageToFilter = int.Parse(Console.ReadLine());
            string[] printFormat = Console.ReadLine().Split();

            if (condition == "younger")
            {
                people = people
                    .Where(p => younger(p, ageToFilter))
                    .ToList();
            }
            else if (condition == "older")
            {
                people = people
                    .Where(p => older(p, ageToFilter))
                    .ToList();
            }

            foreach (var person in people)
            {
                List<string> output = new List<string>();

                if (printFormat.Contains("name"))
                {
                    output.Add(person.Item1);
                }

                if (printFormat.Contains("age"))
                {
                    output.Add(person.Item2.ToString());
                }

                Console.WriteLine(string.Join(" - ", output));
            }
        }
    }
}
