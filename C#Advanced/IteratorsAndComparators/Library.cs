using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndComparators
{
    public class Library: IEnumerable<Book>
    {
        private readonly SortedSet<Book> books;

        public Library(params Book[] _books)
        {
           books = new SortedSet<Book>(_books);
        }

        public IReadOnlyList<Book> Books { get; set; }

        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(books);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private class LibraryIterator : IEnumerator<Book>
        {
            private readonly List<Book> books;
            private int index;

            public LibraryIterator(IEnumerable<Book> books)
            {
                this.books = new List<Book>(books);
                this.index = -1;
            }

            public Book Current => books[index];

            object IEnumerator.Current => Current;

            public bool MoveNext()
            {
                return ++index < this.books.Count;
            }

            public void Reset()
            {
                this.index = -1;
            }

            public void Dispose()
            {

            }
        }
    }
}
