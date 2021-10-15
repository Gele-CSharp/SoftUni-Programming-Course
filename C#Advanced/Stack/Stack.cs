using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Stacks
{
    public class Stack<T>: IEnumerable<T>
    {
        private List<T> elements;

        public Stack(params T[] items)
        {
            elements = new List<T>(items);
        }

        public void Push(params T[] items)
        {
            foreach (var item in items)
            {
                elements.Add(item);
            }
        }

        public T Pop()
        {
            if (elements.Count == 0)
            {
                throw new ArgumentException("No elements");
            }

            T value = elements[elements.Count - 1];
            elements.RemoveAt(elements.Count - 1);
            return value;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = elements.Count - 1; i >= 0; i--)
            {
                yield return elements[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
