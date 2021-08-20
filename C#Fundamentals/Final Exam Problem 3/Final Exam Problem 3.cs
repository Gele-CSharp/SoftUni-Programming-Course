using System;
using System.Collections.Generic;
using System.Linq;

namespace Final_Exam_Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split(new string[] {":"}, StringSplitOptions.RemoveEmptyEntries);

            var healths = new Dictionary<string, decimal>();
            var energies = new Dictionary<string, int>();

            while (command[0].Trim() != "Results")
            {
                if (command[0].Trim() == "Add")
                {
                    string name = command[1].Trim();
                    decimal health = decimal.Parse(command[2].Trim());
                    byte energy = byte.Parse(command[3].Trim());

                    if (healths.ContainsKey(name))
                    {
                        healths[name] += health;
                    }
                    else
                    {
                        healths.Add(name, health);
                        energies.Add(name, energy);
                    }
                }
                else if (command[0].Trim() == "Attack")
                {
                    string attacker = command[1].Trim();
                    string defender = command[2].Trim();
                    int damage = int.Parse(command[3].Trim());

                    if (healths.ContainsKey(attacker) && healths.ContainsKey(defender))
                    {
                        healths[defender] -= damage;
                        energies[attacker]--;

                        if (healths[defender] <= 0)
                        {
                            healths.Remove(defender);
                            energies.Remove(defender);
                            Console.WriteLine($"{defender} was disqualified!");
                        }

                        if (energies[attacker] <= 0)
                        {
                            energies.Remove(attacker);
                            healths.Remove(attacker);
                            Console.WriteLine($"{attacker} was disqualified!");
                        }
                    }
                }
                else if (command[0].Trim() == "Delete")
                {
                    string username = command[1].Trim();

                    if (username == "All")
                    {
                        healths.Clear();
                        energies.Clear();
                    }
                    else
                    {
                        if (healths.ContainsKey(username))
                        {
                            healths.Remove(username);
                            energies.Remove(username);
                        }
                    }
                }

                command = Console.ReadLine().Split(new string[] { ":" }, StringSplitOptions.RemoveEmptyEntries);
            }

            Console.WriteLine($"People count: {healths.Count}");

            foreach (var username in healths.OrderByDescending(u => u.Value))
            {
                foreach (var user in energies.OrderBy(u=>u.Key).Where(u=>u.Key == username.Key))
                {
                    Console.WriteLine($"{username.Key} - {username.Value} - {user.Value}");
                }
            }
        }
    }
}
