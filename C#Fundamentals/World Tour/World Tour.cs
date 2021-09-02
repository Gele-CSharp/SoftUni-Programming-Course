using System;

namespace World_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            string plannedStops = Console.ReadLine();
            string[] command = Console.ReadLine().Split(new string[] { ":" },StringSplitOptions.RemoveEmptyEntries);

            while (command[0] != "Travel")
            {
                if (command[0] == "Add Stop")
                {
                    int index = int.Parse(command[1]);
                    string stop = command[2];

                    if (index >= 0 && index < plannedStops.Length)
                    {
                        plannedStops = plannedStops.Insert(index, stop);
                    }

                    Console.WriteLine(plannedStops);
                }
                else if (command[0] == "Remove Stop")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);

                    if (startIndex >= 0 && startIndex < plannedStops.Length 
                        && endIndex >= 0 && endIndex < plannedStops.Length
                        && endIndex >= startIndex)
                    {
                        plannedStops = plannedStops.Remove(startIndex, endIndex - startIndex + 1);
                    }

                    Console.WriteLine(plannedStops);
                }
                else if (command[0] == "Switch")
                {
                    string oldString = command[1];
                    string newString = command[2];

                    if (plannedStops.Contains(oldString))
                    {
                        plannedStops = plannedStops.Replace(oldString, newString);
                    }

                    Console.WriteLine(plannedStops);
                }

                command = command = Console.ReadLine().Split(new string[] { ":" }, StringSplitOptions.RemoveEmptyEntries);
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {plannedStops}");
        }
    }
}
