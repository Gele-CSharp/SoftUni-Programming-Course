using System;

namespace The_Imitation_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string[] instructions = Console.ReadLine().Split(new string[] { "|" }, StringSplitOptions.RemoveEmptyEntries);

            while (instructions[0] != "Decode")
            {
                if (instructions[0] == "Move")
                {
                    int numberOfLetters = int.Parse(instructions[1]);
                    string substring = message.Substring(0, numberOfLetters);
                    message = message.Remove(0, numberOfLetters);
                    message = string.Concat(message, substring);

                }
                else if (instructions[0] == "Insert")
                {
                    int index = int.Parse(instructions[1]);
                    string value = instructions[2];

                    if (index >= 0 && index <= message.Length)
                    {
                        message = message.Insert(index, value);
                    }
                }
                else if (instructions[0] == "ChangeAll")
                {
                    string substring = instructions[1];
                    string replacement = instructions[2];

                    if (message.Contains(substring))
                    {
                        message = message.Replace(substring, replacement);
                    }
                }

                instructions = Console.ReadLine().Split(new string[] { "|" }, StringSplitOptions.RemoveEmptyEntries);
            }

            Console.WriteLine($"The decrypted message is: {message}");
        }
    }
}
