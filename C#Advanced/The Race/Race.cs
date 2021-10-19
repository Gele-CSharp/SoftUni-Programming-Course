using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheRace
{
    public class Race
    {
        private List<Racer> racers;

        public Race(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            racers = new List<Racer>();
        }

        public string Name { get; private set; }

        public int Capacity { get; private set; }

        public int Count { get; private set; }

        public void Add(Racer racer)
        {
            if (racers.Count < Capacity)
            {
                racers.Add(racer);
                Count++;
            }
        }

        public bool Remove(string name)
        {
            bool isRemoved = false;

            if (racers.Select(r => r.Name).Contains(name))
            {
                Racer racerToRemove = racers.Where(r => r.Name == name).FirstOrDefault();
                racers.Remove(racerToRemove);
                Count--;
                isRemoved = true;
            }

            return isRemoved;
        }

        public Racer GetOldestRacer()
        {
            Racer oldestRacer = racers.OrderByDescending(r => r.Age).FirstOrDefault();
            return oldestRacer;
        }

        public Racer GetRacer(string name)
        {
            Racer racer = racers.Where(r => r.Name == name).FirstOrDefault();
            return racer;
        }

        public Racer GetFastestRacer()
        {
            Racer fastestRacer = racers.OrderByDescending(r => r.Car.Speed).FirstOrDefault();
            return fastestRacer;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Racers participating at {Name}:");

            foreach (var racer in racers)
            {
                sb.AppendLine(racer.ToString());
            }

            return sb.ToString();
        }
    }
}
