using System;

namespace Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            string rawActivationKey = Console.ReadLine();
            string[] command = Console.ReadLine().Split(new string[] { ">>>" }, StringSplitOptions.RemoveEmptyEntries);

            while (command[0] != "Generate")
            {
                if (command[0] == "Contains")
                {
                    string substring = command[1];

                    if (rawActivationKey.Contains(substring))
                    {
                        Console.WriteLine($"{rawActivationKey} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (command[0] == "Flip")
                {
                    int startIndex = int.Parse(command[2]);
                    int endIndex = int.Parse(command[3]);
                    string typeOfLetters = command[1];
                    string substring = rawActivationKey.Substring(startIndex, endIndex - startIndex);

                    if (typeOfLetters == "Upper")
                    {
                        rawActivationKey = rawActivationKey.Replace(substring, substring.ToUpper());
                    }
                    else if (typeOfLetters == "Lower")
                    {
                        rawActivationKey = rawActivationKey.Replace(substring, substring.ToLower());
                    }

                    Console.WriteLine(rawActivationKey);
                }
                else if (command[0] == "Slice")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);

                    rawActivationKey = rawActivationKey.Remove(startIndex, endIndex - startIndex);
                    Console.WriteLine(rawActivationKey);
                }

                command = Console.ReadLine().Split(new string[] { ">>>" }, StringSplitOptions.RemoveEmptyEntries);
            }

            Console.WriteLine($"Your activation key is: {rawActivationKey}");
        }
    }
}
