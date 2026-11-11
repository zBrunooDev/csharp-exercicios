using System;

namespace LibraryRentalSystem.Entities
{
    internal class Book : IComparable<Book>
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
        public int CompareTo(Book other)
        {
            if(other == null) return 1;

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
