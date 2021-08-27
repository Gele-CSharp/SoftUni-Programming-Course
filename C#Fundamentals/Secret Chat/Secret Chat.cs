using System;
using System.Linq;

namespace Secret_Chat
{
    class Program
    {
        static void Main(string[] args)
        {
            string concealedMessage = Console.ReadLine();

            string[] command = Console.ReadLine().Split(new string[] { ":|:" }, StringSplitOptions.RemoveEmptyEntries);

            while (command[0] != "Reveal")
            {
                if (command[0] == "InsertSpace")
                {
                    int index = int.Parse(command[1]);
                    concealedMessage = concealedMessage.Insert(index, " ");
                    Console.WriteLine(concealedMessage);
                }
                else if (command[0] == "Reverse")
                {
                    string substring = command[1];

                    if (concealedMessage.Contains(substring))
                    {
                        int index = concealedMessage.IndexOf(substring);
                        concealedMessage = concealedMessage.Remove(index, substring.Length);
                        char[] reverse = substring.ToCharArray().Reverse().ToArray();
                        substring = string.Join("", reverse);
                        concealedMessage = string.Concat(concealedMessage, substring);
                        Console.WriteLine(concealedMessage);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (command[0] == "ChangeAll")
                {
                    string substring = command[1];
                    string replacement = command[2];

                    if (concealedMessage.Contains(substring))
                    {
                        concealedMessage = concealedMessage.Replace(substring, replacement);
                    }

                    Console.WriteLine(concealedMessage);
                }
                command = Console.ReadLine().Split(new string[] { ":|:" }, StringSplitOptions.RemoveEmptyEntries);
            }

            Console.WriteLine($"You have a new text message: {concealedMessage}");
        }
    }
}
