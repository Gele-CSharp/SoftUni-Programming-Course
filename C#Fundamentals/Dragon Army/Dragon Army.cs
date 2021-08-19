using System;
using System.Collections.Generic;
using System.Linq;

namespace Dragon_Army
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDragons = int.Parse(Console.ReadLine());
            Dictionary<string, List<Dragon>> dragons = new Dictionary<string, List<Dragon>>(numberOfDragons);

            for (int i = 0; i < numberOfDragons; i++)
            {
                string[] dragonInfo = Console.ReadLine().Split();

                string type = dragonInfo[0];
                string name = dragonInfo[1];
                int damage = dragonInfo[2] == "null" ? 45 : int.Parse(dragonInfo[2]);
                int health = dragonInfo[3] == "null" ? 250 : int.Parse(dragonInfo[3]);
                int armor = dragonInfo[4] == "null" ? 10 : int.Parse(dragonInfo[4]);

                Dragon dragon = new Dragon(name, damage, health, armor);

                if (dragons.ContainsKey(type))
                {
                    if (dragons[type].Select(d=>d.Name).Contains(name))
                    {
                        dragons[type].Find(d => d.Name == name).OverwriteStatus(damage, health, armor);
                    }
                    else
                    {
                        dragons[type].Add(dragon);
                    }
                }
                else
                {
                    dragons.Add(type, new List<Dragon>() { new Dragon(name, damage, health, armor) });
                }
            }

            foreach (var typeOfDragons in dragons)
            {
                Console.WriteLine($"{typeOfDragons.Key}::({1.0 *  typeOfDragons.Value.Select(x=>x.Damage).Sum()/typeOfDragons.Value.Count:f2}/" +
                                  $"{1.0 * typeOfDragons.Value.Select(x=>x.Health).Sum()/typeOfDragons.Value.Count:f2}/" +
                                  $"{1.0 * typeOfDragons.Value.Select(x=>x.Armor).Sum()/typeOfDragons.Value.Count:f2})");

                foreach (var dragon in typeOfDragons.Value.OrderBy(x=>x.Name))
                {
                    Console.WriteLine($"-{dragon.Name} -> damage: {dragon.Damage}, health: {dragon.Health}, armor: {dragon.Armor}");
                }
            }
        }
    }

    class Dragon
    {
        public Dragon(string name, int damage, int health, int armor)
        {
            Name = name;
            Damage = damage;
            Health = health;
            Armor = armor;
        }

        public string Name { get; set; }
        public int Damage { get; set; }
        public int Health { get; set; }
        public int Armor { get; set; }

        public void OverwriteStatus(int damage, int health, int armor)
        {
            this.Damage = damage;
            this.Health = health;
            this.Armor = armor;
        }
    }
}
