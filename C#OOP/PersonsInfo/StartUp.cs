using System;
using System.Collections.Generic;

namespace PersonsInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());
            var persons = new List<Person>();
            for (int i = 0; i < lines; i++)
            {
                try
                {
                    var cmdArgs = Console.ReadLine().Split();
                    var person = new Person(cmdArgs[0],
                                            cmdArgs[1],
                                            int.Parse(cmdArgs[2]),
                                            decimal.Parse(cmdArgs[3]));

                    persons.Add(person);
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }

            }

            decimal percentage = decimal.Parse(Console.ReadLine());
            persons.ForEach(p => p.IncreaseSalary(percentage));
            persons.ForEach(p => Console.WriteLine(p.ToString()));

            //Team team = new Team("SoftUni");
            //List<Person> persons = new List<Person>();

            //int numberOfLines = int.Parse(Console.ReadLine());

            //for (int i = 0; i < numberOfLines; i++)
            //{
            //    var cmdArgs = Console.ReadLine().Split();
            //    var person = new Person(cmdArgs[0],
            //                            cmdArgs[1],
            //                            int.Parse(cmdArgs[2]),
            //                            decimal.Parse(cmdArgs[3]));

            //    persons.Add(person);
            //}

            //foreach (Person person in persons)
            //{
            //    team.AddPlayer(person);
            //}

            //Console.WriteLine($"First team has {team.FirstTeam.Count} players.");
            //Console.WriteLine($"Reserve team has {team.ReserveTeam.Count} players.");

        }
    }
}
