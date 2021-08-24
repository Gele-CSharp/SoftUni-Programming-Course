using System;
using System.Collections.Generic;
using System.Linq;

namespace Oldest_Family_Member
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfMembers = int.Parse(Console.ReadLine());
            Family family = new Family();

            for (int i = 0; i < numberOfMembers; i++)
            {
                string[] personInfo = Console.ReadLine().Split();
                string name = personInfo[0];
                int age = int.Parse(personInfo[1]);

                family.AddMember(name, age);
            }

            family.GetOldestMember(family);
        }
    }

    class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Family
    {
        public List<Person> persons { get; set; } = new List<Person>();

        public void AddMember(string name, int age)
        {
            this.persons.Add(new Person(name, age));
        }

        public void GetOldestMember(Family family)
        {
            Person oldestMember = family.persons.OrderByDescending(p => p.Age).First();
            Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
        }
    }
}
