using System;
using System.Collections.Generic;

namespace Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersOfOperations = int.Parse(Console.ReadLine());
            Stack<string> text = new Stack<string>();
            Stack<string> stackedText = new Stack<string>();
            string currentText = string.Empty;

            for (int i = 0; i < numbersOfOperations; i++)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "1")
                {
                    string someString = command[1];

                    for (int j = someString.Length - 1; j >= 0; j--)
                    {
                        text.Push(someString[j].ToString());
                    }

                    currentText = string.Join("", text);
                    stackedText.Push(currentText);
                }
                else if (command[0] == "2")
                {
                    int countOfElements = int.Parse(command[1]);

                    if (countOfElements <= text.Count)
                    {
                        for (int j = 0; j < countOfElements; j++)
                        {
                            text.Pop();
                        }

                        currentText = string.Join("", text);
                        stackedText.Push(currentText);
                    }
                }
                else if (command[0] == "3")
                {
                    int index = int.Parse(command[1]) - 1;
                    string element = currentText.Substring(index, 1);
                    Console.WriteLine(element);
                }
                else if (command[0] == "4")
                {
                    if (stackedText.Count > 1)
                    {
                        stackedText.Pop();
                        currentText = stackedText.Peek();
                        text.Clear();

                        for (int j = currentText.Length - 1; j >= 0; j--)
                        {
                            char element = currentText[j];
                            text.Push(element.ToString());
                        }
                    }
                }
            }
        }
    }
}
