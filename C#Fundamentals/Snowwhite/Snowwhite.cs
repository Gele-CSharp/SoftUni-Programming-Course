using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snowwhite
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> dwarfs = new Dictionary<string, Dictionary<string, int>>();

            string[] dwarfInfo = Console.ReadLine().Split(new string[] { "<", ":", ">" }, StringSplitOptions.RemoveEmptyEntries);

            while (dwarfInfo[0] != "Once upon a time")
            {
                string dwarfName = dwarfInfo[0].Trim();
                string dwarfHatColor = dwarfInfo[1].Trim();
                int dwarfPhysics = int.Parse(dwarfInfo[2]);

                if (dwarfs.ContainsKey(dwarfHatColor))
                {
                    if (dwarfs[dwarfHatColor].ContainsKey(dwarfName))
                    {
                        if (dwarfs[dwarfHatColor][dwarfName] < dwarfPhysics)
                        {
                            dwarfs[dwarfHatColor][dwarfName] = dwarfPhysics;
                        }
                    }
                    else
                    {
                        dwarfs[dwarfHatColor].Add(dwarfName, dwarfPhysics);
                    }
                }
                else
                {
                    dwarfs.Add(dwarfHatColor, new Dictionary<string, int>() { { dwarfName, dwarfPhysics } });
                }

                dwarfInfo = Console.ReadLine().Split(new string[] { "<", ":", ">" }, StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var dwarfHatColor in dwarfs.OrderByDescending(d => d.Value.Values.Sum()))
            {
                foreach (var dwarf in dwarfHatColor.Value.OrderByDescending(d => d.Value))
                {
                    Console.WriteLine($"({dwarfHatColor.Key}) {dwarf.Key} <-> {dwarf.Value}");
                }
            }
        }
    }
}

