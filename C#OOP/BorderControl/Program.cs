using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Citizen> citizens = new List<Citizen>();

            while (true)
            {
                string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "End")
                {
                    break;
                }

                if (command.Length == 3)
                {
                    string name = command[0];
                    string age = command[1];
                    string id = command[2];

                    Citizen person = new Person(id, name, age);
                    citizens.Add(person);
                }
                else if (command.Length == 2)
                {
                    string model = command[0];
                    string id = command[1];

                    Citizen robot = new Robot(id, model);
                    citizens.Add(robot);
                }
            }

            string fakeIDsDigits = Console.ReadLine();

            Func<string, string, bool> isIDFake = (ID, fakeIDsDigits) => ID.EndsWith(fakeIDsDigits);

            List<Citizen> citizensToDetain = citizens.Where(c => isIDFake(c.ID, fakeIDsDigits)).ToList();

            foreach (var citizen in citizensToDetain)
            {
                Console.WriteLine(citizen.ID);
            }
        }
    }
}
