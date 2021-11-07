using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<IBirthDate> birthDays = new List<IBirthDate>();

            while (true)
            {
                string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "End")
                {
                    break;
                }

                if (command[0] == "Citizen")
                {
                    string name = command[1];
                    string age = command[2];
                    string id = command[3];
                    string birthDate = command[4];

                    IBirthDate person = new Person(id, name, age, birthDate);
                    birthDays.Add(person);
                }
                else if (command[0] == "Pet")
                {
                    string name = command[1];
                    string birthDate = command[2];

                    IBirthDate pet = new Pet(name, birthDate);
                    birthDays.Add(pet);
                }
                else if (command[0] == "Robot")
                {
                    string id = command[1];
                    string model = command[2];

                    Citizen robot = new Robot(id, model);
                }
            }

            //string fakeIDsDigits = Console.ReadLine();

            //Func<string, string, bool> isIDFake = (ID, fakeIDsDigits) => ID.EndsWith(fakeIDsDigits);

            //List<Citizen> citizensToDetain = citizens.Where(c => isIDFake(c.ID, fakeIDsDigits)).ToList();


            //foreach (var citizen in citizensToDetain)
            //{
            //    Console.WriteLine(citizen.ID);
            //}

            string year = Console.ReadLine();

            bool isYearMatches(string birthDate, string year) => birthDate.EndsWith(year);

            foreach (var date in birthDays.Where(b => isYearMatches(b.BirtDate, year)))
            {
                Console.WriteLine(date.BirtDate);
            }
        }
    }
}
