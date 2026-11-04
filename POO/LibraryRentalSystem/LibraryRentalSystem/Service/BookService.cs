using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using LibraryRentalSystem.Entities;
using LibraryRentalSystem.Repository;

namespace LibraryRentalSystem.Service
{
    internal class BookService
    {

        private readonly BookRepository _bookRepository;
        public BookService(BookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        // Verify if has books duplicated
        public void AddBookInLibrary(Book book)
        {
            if (string.IsNullOrWhiteSpace(book.BookKey))
                throw new ArgumentException("The book key cannot be null or empty.", nameof(book));

            if (string.IsNullOrWhiteSpace(book.Title))
                throw new ArgumentException("The book title cannot be null or empty.", nameof(book));

            if (string.IsNullOrWhiteSpace(book.Author))
                throw new ArgumentException("The author of the book (Author) cannot be null or empty.", nameof(book));

            var actualList = _bookRepository.GetAll();

            if (actualList.Any(existingBook =>
                    existingBook.BookKey == book.BookKey))
            {
                throw new Exception("This book is already registered.");
            }
            _bookRepository.AddBook(book);
        }

        // Output books.

        public SortedSet<Book> AllBooks()
        {
            var actualList = _bookRepository.GetAll();
            if(actualList.Count == 0)
            {
                throw new Exception("A list is empty!");
            }
            return actualList;
        }

    }
}
