using System;
using System.Collections;
using System.Collections.Generic;

namespace ListyIterators
{
    public class ListyIterator<T>: IEnumerable<T>
    {
        private List<T> items;
        private int index;

        public ListyIterator(params T[] data)
        {
            items = new List<T>(data);
           index = 0;
        }

        public bool Move()
        {
            bool canMove = HasNext();
            if (canMove) index++;
            return canMove;
        }

        public bool HasNext() => index < items.Count - 1;

        public void Print()
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
            else
            {
                Console.WriteLine(items[index]);
            }
        }

        public void PrintAll()
        {
            foreach (var item in items)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in items)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
