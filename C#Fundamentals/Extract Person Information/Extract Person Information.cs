using System;
using System.Text.RegularExpressions;

namespace Extract_Person_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            string namePattern = @"@([A-z]+)\|";
            string agePattern = @"#([0-9]+)\*";

            for (int i = 0; i < numberOfLines; i++)
            {
                string personInfo = Console.ReadLine();

                Match name = Regex.Match(personInfo, namePattern);
                Match age = Regex.Match(personInfo, agePattern);

                if (name.Success && age.Success)
                {
                    Console.WriteLine($"{name.Groups[1].Value} is {age.Groups[1].Value} years old.");
                }
            }
        }
    }
}
