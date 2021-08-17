using System;
using System.Collections.Generic;
using System.Linq;

namespace Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                                .ToList();

            string[] command = Console.ReadLine().Split();

            while (command[0] != "3:1")
            {
                if (command[0] == "merge")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);

                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }
                    else if (startIndex > input.Count - 1)
                    {
                        startIndex = input.Count - 1;
                    }

                    if (endIndex > input.Count - 1)
                    {
                        endIndex = input.Count - 1;
                    }
                    else if (endIndex < 0)
                    {
                        endIndex = 0;
                    }

                    for (int i = 0; startIndex < endIndex; i++)
                    {
                        input[startIndex] += input[startIndex + 1];
                        input.RemoveAt(startIndex + 1);
                        endIndex--;
                    }
                }
                else if (command[0] == "divide")
                {
                    int index = int.Parse(command[1]);
                    int partitions = int.Parse(command[2]);

                    string textToDivide = input[index];
                    List<string> text = new List<string>();
                    input.RemoveAt(index);
                    int counter = 0;

                    for (int i = textToDivide.Length - 1; 0 <= i; i--)
                    {
                        if (textToDivide.Length % 2 != 0 && i == textToDivide.Length - 1)
                        {
                            counter--;
                        }

                        text.Add(textToDivide[i].ToString());
                        counter++;

                        if (counter == textToDivide.Length / partitions)
                        {
                            text.Reverse();
                            input.Insert(index, string.Join("", text));
                            counter = 0;
                            text.Clear();
                        }
                    }
                }

                command = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
