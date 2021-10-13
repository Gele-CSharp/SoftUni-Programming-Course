using System;
using System.Collections.Generic;

namespace IteratorsAndComparators
{
    public class Book: IComparable<Book>
    {
        public Book(string title, int year, params string[] authors)
        {
            Title = title;
            Year = year;
            Authors = authors;
        }

        public string Title { get; set; }
        public int Year { get; set; }
        public IReadOnlyList<string> Authors { get; set; }

        public int CompareTo(Book other)
        {
            if (this.Year != other.Year)
            {
                return this.Year.CompareTo(other.Year);
            }
            else
            {
                return this.Title.CompareTo(other.Title);
            }
        }

        public override string ToString()
        {
            return ($"{Title} {Year}").ToString();
        }
    }
}
