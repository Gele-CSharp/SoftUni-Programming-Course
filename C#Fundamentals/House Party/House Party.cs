using System;
using System.Collections.Generic;

namespace House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            List<string> listOfGuests = new List<string>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] message = Console.ReadLine().Split();
                string name = message[0];

                if (message[2] != "not")
                {
                    if (listOfGuests.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        listOfGuests.Add(name);
                    }    
                }
                else
                {
                    if (listOfGuests.Contains(name))
                    {
                        listOfGuests.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
            }

            foreach (var person in listOfGuests)
            {
                Console.WriteLine(person);
            }
        }
    }
}
