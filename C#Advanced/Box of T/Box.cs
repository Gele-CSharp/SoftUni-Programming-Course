using System;
using System.Collections.Generic;

namespace BoxOfT
{
    public class Box<T>
    {
        private List<T> items;

        public Box()
        {
            this.items = new List<T>();
        }

        public int Count { get; private set; }

        public void Add(T element)
        {
            this.items.Add(element);
            this.Count++;
        }

        public T Remove()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("The Box is Empty!");
            }

            T value = this.items[items.Count - 1];
            this.items.RemoveAt(items.Count - 1);
            this.Count--;
            return value;
        }
    }
}
