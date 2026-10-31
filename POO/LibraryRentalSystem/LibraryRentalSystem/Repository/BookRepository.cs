using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryRentalSystem.Entities;

namespace LibraryRentalSystem.Repository
{
    internal class BookRepository
    {
        private SortedSet<Book> Books { get; set; } = new SortedSet<Book>();

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public SortedSet<Book> GetAll()
        {
            return Books;
        }

        // Get By ID books
        public Book GetBookById(string BookKey)
        {
            foreach (Book book in Books)
            {
                if(book.BookKey == BookKey) return book;
            }
            return null;
        }
    }
}
