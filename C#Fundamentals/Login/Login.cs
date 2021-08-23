using System;
using System.Linq;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            char[] passwordChars = userName.Reverse().ToArray();
            string correctPassword = string.Join("", passwordChars);
            string password = Console.ReadLine();
            int counter = 0;

            while (password != correctPassword && counter < 3)
            {
                Console.WriteLine("Incorrect password. Try again.");
                counter++;
                password = Console.ReadLine();
            }

            if (password == correctPassword)
            {
                Console.WriteLine($"User {userName} logged in.");
            }
            else
            {
                Console.WriteLine($"User {userName} blocked!");
            }
        }
    }
}
