using System;
using System.Collections.Generic;
using System.Linq;

namespace Order_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] personInfo = Console.ReadLine().Split();
            List<Person> persons = new List<Person>();

            while (personInfo[0] != "End")
            {
                string name = personInfo[0];
                string ID = personInfo[1];
                int age = int.Parse(personInfo[2]);

                Person person = new Person(name, ID, age);
                persons.Add(person);

               personInfo = Console.ReadLine().Split();
            }

            foreach (Person person in persons.OrderBy(p=>p.Age))
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
            }
        }
    }

    class Person
    {
        public Person(string name, string ID, int age)
        {
            Name = name;
            this.ID = ID;
            Age = age;
        }

        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
    }
}
