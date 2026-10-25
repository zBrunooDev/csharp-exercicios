using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LibraryRentalSystem.Entities
{
    internal class Book
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
            return other.Equals(this);
        }
    }
}
