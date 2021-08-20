using System;
using System.Text.RegularExpressions;

namespace Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string emailPattern = @"\s{1}([a-z]+\.{0,1}-{0,1}_{0,1}[a-z]*@{1}[a-z]+\.[a-z]+\.*-*[a-z]+)";

            string input = Console.ReadLine();

            MatchCollection emails = Regex.Matches(input, emailPattern);

            foreach (Capture email in emails)
            {
                Console.WriteLine(email);
            }
        }
    }
}
