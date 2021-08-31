using System;
using System.Text;

namespace Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder validUsername = new StringBuilder();

            for (int i = 0; i < usernames.Length; i++)
            {
                if (usernames[i].Length < 3 || usernames[i].Length > 16)
                {
                    //for (int j = 0; j < usernames[i].Length; j++)
                    //{
                    //    if (Char.IsDigit(usernames[i][j]) || char.IsLetter(usernames[i][j]) || usernames[i][j] == '-' || usernames[i][j] == '_')
                    //    {
                    //        validUsername.Append(usernames[i][j]);
                    //    }
                    //    else
                    //    {
                    //        break;
                    //    }
                    //}

                    //if (validUsername.Length > 0)
                    //{
                    //    Console.WriteLine(validUsername.ToString());
                    //}

                    //validUsername.Clear();

                    continue;
                }

                bool isValid = true;

                foreach (var character in usernames[i])
                {
                    if (char.IsDigit(character) == false
                        && char.IsLetter(character) == false
                        && character != '-'
                        && character != '_')
                    {
                        isValid = false;
                            break;
                    }
                }

                if (isValid)
                {
                    Console.WriteLine(usernames[i]);
                }
            }
        }
    }
}
