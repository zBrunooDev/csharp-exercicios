using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LibraryRentalSystem.Entities
{
    internal class Book : IComparable
    {
        public string BookKey { get; private set; }
        public string Title { get; private set; }
        public string Author { get; private set; }

        public Book(string bookKey, string title, string author)
        {
            BookKey = bookKey;
            Title = title;
            Author = author;
        }

        public override int GetHashCode()
        {
            return BookKey.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if(!(obj is Book))
            {
                throw new ArgumentException("It does not correspond to the correct object type.");
            }
            Book other = obj as Book;
            return BookKey == other.BookKey;
        }

        public int CompareTo(object obj)
        {
            if (!(obj is  Book other))
                throw new ArgumentException("Invalid object type.");

            int titleComparsion = Title.CompareTo(other.Title);
            if(titleComparsion != 0)
                return titleComparsion; 

            return BookKey.CompareTo(other.BookKey);
        }

        public override string ToString()
        {
            return $"Code: {BookKey}, Title: {Title}, Author: {Author}";
        }
    }
}
