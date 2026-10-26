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

    }
}
