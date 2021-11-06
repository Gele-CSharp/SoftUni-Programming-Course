using System;
using System.Collections.Generic;

namespace ExplicitInterfaces
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Citizen> citizens = new List<Citizen>();

            while (true)
            {
                string[] citizenInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = citizenInfo[0];

                if (name == "End")
                {
                    break;
                }

                string country = citizenInfo[1];
                int age = int.Parse(citizenInfo[2]);

                Citizen citizen = new Citizen(name, age, country);
                citizens.Add(citizen);
            }

            foreach (var citizen in citizens)
            {
                IPerson person = citizen;
                IResident resident = citizen;

                Console.WriteLine(person.GetName());
                Console.WriteLine(resident.GetName());
            }
        }
    }
}
