using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkiRental
{
    public class SkiRental
    {
        public SkiRental(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            ListOfSki = new List<Ski>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public List<Ski> ListOfSki { get; set; }
        public int Count { get; private set; }

        public void Add(Ski ski)
        {
            if (this.ListOfSki.Count + 1 <= this.Capacity)
            {
                this.ListOfSki.Add(ski);
                this.Count++;
            }
        }

        public bool Remove(string manufacturer, string model)
        {
            bool isRemoved = false;

            if (this.ListOfSki.Select(s => s.Manufacturer).Contains(manufacturer)
                && this.ListOfSki.Select(s => s.Model).Contains(model))
            {
                Ski skiToRemove = this.ListOfSki.Where(s => s.Manufacturer == manufacturer && s.Model == model).FirstOrDefault();
                this.ListOfSki.Remove(skiToRemove);
                this.Count--;
                isRemoved = true;
            }

            return isRemoved;
        }

        public Ski GetNewestSki()
        {
            if (this.ListOfSki.Count > 0)
            {
                Ski newestSki = this.ListOfSki.OrderByDescending(s => s.Year).FirstOrDefault();
                return newestSki;
            }

            return null;
        }

        public Ski GetSki(string manufacturer, string model)
        {
            Ski ski = this.ListOfSki.Where(s => s.Manufacturer == manufacturer && s.Model == model).FirstOrDefault();
            return ski;
        }

        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"The skis stored in {this.Name}:");

            foreach (var ski in this.ListOfSki)
            {
                sb.AppendLine(ski.ToString());
            }

            return sb.ToString();
        }
    }
}