using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Post_Office
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('|');
            Dictionary<string, string> wordsDetails = new Dictionary<string, string>();

            for (int i = 0; i < input.Length; i++)
            {
                if (i == 0)
                {
                    string messagePart = input[i].Trim();

                    string capitalLettersPattern = @"([#$%*&]{1})([A-Z]+)\1";

                    Match matchedLetters = Regex.Match(messagePart, capitalLettersPattern);

                    if (matchedLetters.Success)
                    {
                        string letters = matchedLetters.Groups[2].Value.ToString();

                        foreach (var letter in letters)
                        {
                            wordsDetails.Add(letter.ToString(), "0");
                        }
                    }
                }
                else if (i == 1)
                {
                    string messagePart = input[i].Trim();

                    string wordLengthPattern = @"([0-9]{2}):([0-9]{2})";

                    MatchCollection wordsLengths = Regex.Matches(messagePart, wordLengthPattern);

                    foreach (Match letterAndLength in wordsLengths)
                    {
                        string[] currentLetterAndLength = letterAndLength.Value.Split(':');
                        string currentLetter = Convert.ToChar(int.Parse(currentLetterAndLength[0])).ToString();
                        int currentLength = int.Parse(currentLetterAndLength[1]);

                        if (wordsDetails.ContainsKey(currentLetter))
                        {
                            wordsDetails[currentLetter] = currentLength.ToString();
                        }
                    }
                }
                else if (i == 2)
                {
                    string messagePart = input[i].Trim();

                    foreach (var word in wordsDetails)
                    {
                        string lettersAndLength = "\\" + "s" + "[" + word.Key.ToString() + "]" + "[!-~]" + "{" + word.Value.ToString() + "}" + "\\" +"b";
                        string wordPattern = $@"{lettersAndLength}";

                        Match currentWord = Regex.Match(messagePart, wordPattern);

                        if (currentWord.Success )
                        {
                            Console.WriteLine(currentWord.Value.ToString().Trim());
                        }
                    }
                }
            }
        }
    }
}
