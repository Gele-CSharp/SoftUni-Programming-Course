using System;
using System.Collections.Generic;
using System.Linq;

namespace MilitaryElite
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<ISoldier> soldiers = new List<ISoldier>();

            while (true)
            {
                string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string soldierType = command[0];

                if (soldierType == "End")
                {
                    break;
                }

                string id = command[1];
                string firstName = command[2];
                string lastName = command[3];
                decimal salary = decimal.Parse(command[4]);

                if (soldierType == "Private")
                {
                    Private @private = new Private(id, firstName, lastName, salary);
                    soldiers.Add(@private);
                }
                else if (soldierType == "LieutenantGeneral")
                {
                    List<string> privatesIDs = command.Skip(5).ToList();
                    List<ISoldier> listOfPrvivates = new List<ISoldier>();

                    foreach (var privateID in privatesIDs)
                    {
                        if (soldiers.Select(p=> p.ID).Contains(privateID))
                        {
                            var privateToAdd = soldiers.FirstOrDefault(p => p.ID == privateID);
                            listOfPrvivates.Add(privateToAdd);
                        }
                    }

                    LieutenantGeneral lieutenantGeneral = new LieutenantGeneral(id, firstName, lastName, salary, listOfPrvivates);
                    soldiers.Add(lieutenantGeneral);
                }
                else if (soldierType == "Engineer")
                {
                    string corps = command[5];
                    bool isCorpsValid = Enum.TryParse(corps, out Corps result); 

                    if (isCorpsValid == false)
                    {
                        continue;
                    }

                    List<string> repairsInfo = command.Skip(6).ToList();
                    List<Repair> repairs = new List<Repair>();

                    for (int i = 0; i < repairsInfo.Count - 1; i += 2)
                    {
                        string repairPart = repairsInfo[i];
                        string workedHours = repairsInfo[i + 1];

                        Repair repair = new Repair(repairPart, workedHours);
                        repairs.Add(repair);
                    }

                    Engineer engineer = new Engineer(id, firstName, lastName, result, salary, repairs);
                    soldiers.Add(engineer);
                }
                else if (soldierType == "Commando")
                {
                    string corps = command[4];
                    List<string> missionsInfo = command.Skip(6).ToList();
                    List<Mission> missions = new List<Mission>();

                    for (int i = 0; i < missionsInfo.Count - 1; i += 2)
                    {
                        string codeName = missionsInfo[i];
                        string state = missionsInfo[i + 1];

                        bool isMissionStateValid = Enum.TryParse(state, out MissionState result);

                        if (isMissionStateValid == false)
                        {
                            continue;
                        }

                        Mission mission = new Mission(codeName, result);
                        missions.Add(mission);
                    }

                    ISoldier commando = new Commando(id, firstName, lastName, missions, salary);
                    soldiers.Add(commando);
                }
                else if (soldierType == "Spy")
                {
                    int codeNumber = int.Parse(command[4]);

                    ISoldier spy = new Spy(id, firstName, lastName, codeNumber);
                    soldiers.Add(spy);
                }
            }

            foreach (var soldier in soldiers)
            {
                Console.WriteLine(soldier);
            }
        }
    }
}
