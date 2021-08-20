using System;
using System.Collections.Generic;
using System.Linq;

namespace ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> forceSides = new Dictionary<string, List<string>>();

            string[] input = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "Lumpawaroo")
            {   
                if (input.Contains("|"))
                {
                    string[] info = string.Join(" ", input).Split('|');
                    string forceSide = info[0].Trim();
                    string forceUser = info[1].Trim();

                    if (forceSides.ContainsKey(forceSide) == false)
                    {
                        forceSides.Add(forceSide, new List<string>());
                    }

                    if (forceSides[forceSide].Contains(forceUser) == false)
                    {
                        forceSides[forceSide].Add(forceUser);
                    }
                }
                else if (input.Contains("->"))
                {
                    string[] info = string.Join(" ", input).Split(new string[] { "-", ">" }, StringSplitOptions.RemoveEmptyEntries);
                    string forceSide = info[1].Trim();
                    string forceUser = info[0].Trim();

                    bool isForceUserExist = false;

                    foreach (var side in forceSides)
                    {
                        if (side.Value.Contains(forceUser))
                        {
                            forceSides[side.Key].Remove(forceUser);
                            forceSides[forceSide].Add(forceUser);
                            Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                            isForceUserExist = true;
                        }
                    }

                    if (isForceUserExist == false)
                    {
                        if (forceSides.ContainsKey(forceSide))
                        {
                            forceSides[forceSide].Add(forceUser);
                        }
                        else
                        {
                            forceSides.Add(forceSide, new List<string> { forceUser });
                        }

                        Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                    }
                }

                input = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var forceSide in forceSides.OrderByDescending(f=>f.Value.Count).ThenBy(f=>f.Key).Where(f=>f.Value.Count > 0))
            {
                Console.WriteLine($"Side: {forceSide.Key}, Members: {forceSide.Value.Count} ");

                foreach (var forceUser in forceSide.Value.OrderBy(f=>f))
                {
                    Console.WriteLine($"! {forceUser}");
                }
            }
        }
    }
}
