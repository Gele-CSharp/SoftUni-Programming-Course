using System;
using System.Text.RegularExpressions;

namespace Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            //!!! solution in fundamentals test is better!
            string input = Console.ReadLine();
            string pattern = @"\b\\([A-z]+)\.([a-z]+)";
            string fileName = string.Empty;
            string fileExtension = string.Empty;

            Match match = Regex.Match(input, pattern);

            if (match.Success)
            {
                fileName = match.Groups[1].Value;
                fileExtension = match.Groups[2].Value;
            }

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");
        }
    }
}
