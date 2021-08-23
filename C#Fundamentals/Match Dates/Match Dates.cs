using System;
using System.Text.RegularExpressions;

namespace Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string dates = Console.ReadLine();
            string datePattern = @"\b(?<day>[0-9]{2})(?<separator>\/*-*\.*){1}(?<month>[A-z]{1}[a-z]{2})\k<separator>(?<year>[0-9]{4})\b";

            MatchCollection validDates = Regex.Matches(dates, datePattern);

            foreach (Match date in validDates)
            {
                Console.WriteLine($"Day: {date.Groups[1]}, Month: {date.Groups[3]}, Year: {date.Groups[4]}");
            }
        }
    }
}
