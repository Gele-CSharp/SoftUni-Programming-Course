using System;

namespace Data_Type_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string type = "string";
            int counter = 0;

            while (input != "END")
            {
                type = "string";

                if (input == "true" || input == "false")
                {
                    type = "boolean";
                }
                else if (input.Length == 1 && Char.IsDigit(char.Parse(input)) == false)
                {
                    type = "character";
                }
                else
                {
                    bool isInteger = true;

                    for (int i = 0; i < input.Length; i++)
                    {
                        if (input[i] == '.' && input[i] != input[0])
                        {
                            counter++;
                        }

                        if ((Char.IsDigit(input[i]) && isInteger)
                            || (input[i] == '-' && i == 0)
                            || (input[i] == '.' && counter == 1))
                        {
                            if (input[i] == '-' && input[i + 1] == '0' && input.Length == 2)
                            {
                                type = "string";
                                break;
                            }

                            type = "integer";
                        }
                        else
                        {
                            type = "string";
                            isInteger = false;
                        }
                    }

                    if (type == "integer" && counter == 1)
                    {
                        type = "floating point";
                        counter = 0;
                    }
                }

                Console.WriteLine($"{input} is {type} type");
                input = Console.ReadLine();
            }
        }
    }
}
