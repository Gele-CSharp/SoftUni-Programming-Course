using System;
using System.Collections.Generic;

namespace CustomRandomList
{
    public class RandomList: List<string>
    {
        private List<string> items;

        public RandomList(params string[] items)
        {
            this.items = new List<string>(items);
        }

        public string RandomString()
        {
            Random rnd = new Random();
            int index = rnd.Next(0, this.Count - 1);
            string randomString = this[index];
            this.RemoveAt(index);
            return randomString;
        }
    }
}
