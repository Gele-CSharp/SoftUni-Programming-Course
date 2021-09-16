using System;
using System.Collections.Generic;

namespace SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> vipGuests = new HashSet<string>();
            HashSet<string> regularGuests = new HashSet<string>();
            HashSet<string> peopleAtTheParty = new HashSet<string>();

            string input = Console.ReadLine();

            while (input != "PARTY")
            {
                string reservatinNumber = input;

                if (Char.IsDigit(reservatinNumber[0]))
                {
                    vipGuests.Add(reservatinNumber);
                }
                else if (Char.IsLetter(reservatinNumber[0]))
                {
                    regularGuests.Add(reservatinNumber);
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "END")
            {
                string reservatinNumber = input;
                peopleAtTheParty.Add(reservatinNumber);
                input = Console.ReadLine();
            }

            vipGuests.ExceptWith(peopleAtTheParty);
            regularGuests.ExceptWith(peopleAtTheParty);

            Console.WriteLine(vipGuests.Count + regularGuests.Count);

            foreach (var guest in vipGuests)
            {
                Console.WriteLine(guest);
            }

            foreach (var guest in regularGuests)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
