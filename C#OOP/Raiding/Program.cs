using System;
using System.Collections.Generic;
using System.Linq;

namespace Raiding
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            List<BaseHero> heroes = new List<BaseHero>();

            for (int i = 0; i < numberOfLines; i++)
            {
                string name = Console.ReadLine();
                string heroType = Console.ReadLine();

                bool isHeroTypeValid = Enum.TryParse(heroType, out Heroes result);

                if (isHeroTypeValid == false)
                {
                    Console.WriteLine("Invalid hero!");
                    i--;
                    continue;
                }
                else
                {
                    if (result == Heroes.Druid)
                    {
                        BaseHero hero = new Druid(name);
                        heroes.Add(hero);
                    }
                    else if (result == Heroes.Paladin)
                    {
                        BaseHero hero = new Paladin(name);
                        heroes.Add(hero);
                    }
                    else if (result == Heroes.Warrior)
                    {
                        BaseHero hero = new Warrior(name);
                        heroes.Add(hero);
                    }
                    else if (result == Heroes.Rogue)
                    {
                        BaseHero hero = new Rogue(name);
                        heroes.Add(hero);
                    }
                }
            }

            int bossPower = int.Parse(Console.ReadLine());

            foreach (var hero in heroes)
            {
                Console.WriteLine(hero.CastAbility());
            }

            int totalPower = heroes.Select(h => h.Power).Sum();

            Console.WriteLine(totalPower - bossPower >= 0 ? "Victory!" : "Defeat...");
        }
    }
}
