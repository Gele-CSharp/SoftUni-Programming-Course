using System;
using System.Collections.Generic;

namespace Unique_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());
            HashSet<string> usernames = new HashSet<string>();

            for (int i = 0; i < numberOfInputs; i++)
            {
                string username = Console.ReadLine();
                usernames.Add(username);
            }

            foreach (var username in usernames)
            {
                Console.WriteLine(username);
            }
        }
    }
}
