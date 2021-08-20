using System;
using System.Linq;

namespace Final_Exam_Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            string[] command = Console.ReadLine().Split();

            while (command[0] != "Registration")
            {
                if (command[0] == "Letters")
                {
                    if (command[1] == "Lower")
                    {
                        username = username.ToLower();
                    }
                    else if (command[1] == "Upper")
                    {
                        username = username.ToUpper();
                    }

                    Console.WriteLine(username);
                }
                else if (command[0] == "Reverse")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);

                    if (startIndex >= 0 && endIndex < username.Length)
                    {
                        string substring = username.Substring(startIndex, endIndex - startIndex + 1);
                        char[] reverse = substring.ToCharArray().Reverse().ToArray();
                        Console.WriteLine(string.Join("", reverse));
                    }
                }
                else if (command[0] == "Substring")
                {
                    string substring = command[1];

                    if (username.Contains(substring))
                    {
                        int index = username.IndexOf(substring);
                        username = username.Remove(index, substring.Length);
                        Console.WriteLine(username);
                    }
                    else
                    {
                        Console.WriteLine($"The username {username} doesn't contain {substring}.");
                    }
                }
                else if (command[0] == "Replace")
                {
                    string character = command[1];

                    username = username.Replace(character, "-");
                    Console.WriteLine(username);
                }
                else if (command[0] == "IsValid")
                {
                    string character = command[1];

                    if (username.Contains(character))
                    {
                        Console.WriteLine("Valid username.");
                    }
                    else
                    {
                        Console.WriteLine($"{character} must be contained in your username.");
                    }
                }

                command = Console.ReadLine().Split();
            }
        }
    }
}
