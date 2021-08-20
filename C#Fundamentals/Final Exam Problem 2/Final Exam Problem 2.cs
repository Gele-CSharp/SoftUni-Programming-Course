using System;
using System.Text.RegularExpressions;

namespace Final_Exam_Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfInputs; i++)
            {
                string input = Console.ReadLine();
                string messagePattern = @"^([$%]{1})([A-Z]{1}[a-z]{2,})\1:{1}\s{1}\[([0-9]+)\]\|\[([0-9]+)\]\|\[([0-9]+)\]\|$";

                Match message = Regex.Match(input, messagePattern);

                if (message.Success)
                {
                    string tag = message.Groups[2].Value.ToString();
                    string decryptedMessage = string.Empty;

                    for (int j = 3; j < 6; j++)
                    {
                        int charValue = Convert.ToInt32(message.Groups[j].Value.ToString());
                        decryptedMessage += Convert.ToChar(charValue);
                    }

                    Console.WriteLine($"{tag}: {decryptedMessage}");
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }
        }
    }
}
