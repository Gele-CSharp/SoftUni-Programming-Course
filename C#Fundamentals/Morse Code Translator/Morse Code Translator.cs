using System;
using System.Collections.Generic;
using System.Text;

namespace Morse_Code_Translator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] morseCode = Console.ReadLine().Split('|');
            List<string> message = new List<string>();
            StringBuilder word = new StringBuilder();

            for (int i = 0; i < morseCode.Length; i++)
            {
                string currentWord = morseCode[i].Trim();
                string[] currentWordLetters = currentWord.Split();

                for (int j = 0; j < currentWordLetters.Length; j++)
                {
                    string currentLetter = currentWordLetters[j].ToString();

                    switch (currentLetter)
                    {
                        case ".-": 
                            currentLetter = "A";
                            break;
                        case "-...":
                            currentLetter = "B";
                            break;
                        case "-.-.":
                            currentLetter = "C";
                            break;
                        case "-..":
                            currentLetter = "D";
                            break;
                        case ".":
                            currentLetter = "E";
                            break;
                        case "..-.":
                            currentLetter = "F";
                            break;
                        case "--.":
                            currentLetter = "G";
                            break;
                        case "....":
                            currentLetter = "H";
                            break;
                        case "..":
                            currentLetter = "I";
                            break;
                        case ".---":
                            currentLetter = "J";
                            break;
                        case "-.-":
                            currentLetter = "K";
                            break;
                        case ".-..":
                            currentLetter = "L";
                            break;
                        case "--":
                            currentLetter = "M";
                            break;
                        case "-.":
                            currentLetter = "N";
                            break;
                        case "---":
                            currentLetter = "O";
                            break;
                        case ".--.":
                            currentLetter = "P";
                            break;
                        case "--.-":
                            currentLetter = "Q";
                            break;
                        case ".-.":
                            currentLetter = "R";
                            break;
                        case "...":
                            currentLetter = "S";
                            break;
                        case "-":
                            currentLetter = "T";
                            break;
                        case "..-":
                            currentLetter = "U";
                            break;
                        case "...-":
                            currentLetter = "V";
                            break;
                        case ".--":
                            currentLetter = "W";
                            break;
                        case "-..-":
                            currentLetter = "X";
                            break;
                        case "-.--":
                            currentLetter = "Y";
                            break;
                        case "--..":
                            currentLetter = "Z";
                            break;
                    }

                    word.Append(currentLetter);
                }

                message.Add(word.ToString());
                word.Clear();
            }

            Console.WriteLine(string.Join(" ", message));
        }
    }
}
