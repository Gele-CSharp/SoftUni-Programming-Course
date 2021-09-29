using System;
using System.Collections.Generic;
using System.Linq;

namespace Predicate_Party_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> people = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Func<string, string, bool> nameStartString 
                = (name, certainString) => name.Substring(0, certainString.Length) != certainString;

            Func<string, string, bool> nameEndString 
                = (name, certainString) => name.Substring((name.Length - certainString.Length), certainString.Length) != certainString;

            Func<string, int, bool> nameLength = (name, length) => name.Length == length;

            while (true)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "Party!")
                {
                    break;
                }

                if (command[0] == "Remove")
                {
                    string certainString = command[2];

                    if (command[1] == "StartsWith")
                    {
                        people = people.Where(p => nameStartString(p, certainString)).ToList();
                    }
                    else if (command[1] == "EndsWith")
                    {
                        people = people.Where(p => nameEndString(p, certainString)).ToList();
                    }
                    else if (command[1] == "Length")
                    {
                        int length = int.Parse(command[2]);
                        people = people.Where(p => nameLength(p, length)).ToList();
                    }
                }
                else if (command[0] == "Double")
                {
                    string certainString = command[2];
                    List<string> peopleToDouble = new();
                    List<string> doubledListOfPeople = new();

                    if (command[1] == "StartsWith")
                    {
                        peopleToDouble = people.Where(p => !nameStartString(p, certainString)).ToList();
                    }
                    else if (command[1] == "EndsWith")
                    {
                        peopleToDouble = people.Where(p => !nameEndString(p, certainString)).ToList();
                    }
                    else if (command[1] == "Length")
                    {
                        int length = int.Parse(command[2]);
                        peopleToDouble = people.Where(p => nameLength(p, length)).ToList();
                    }

                    foreach (var person in people)
                    {
                        if (peopleToDouble.Contains(person))
                        {
                            doubledListOfPeople.Add(person);
                        }
                        
                        doubledListOfPeople.Add(person);
                    }

                    people = doubledListOfPeople;
                }    
            }

            if (people.Count > 0)
            {
                Console.Write($"{string.Join(", ", people)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }
    }
}
