using System;
using System.Collections.Generic;
using System.Linq;
using LibraryRentalSystem.Entities;
using LibraryRentalSystem.Repository;
using System.Text.RegularExpressions;


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
            if (book == null)
                throw new ArgumentNullException(nameof(book));

            if (string.IsNullOrWhiteSpace(book.BookKey))
                throw new ArgumentException("The book key cannot be null or empty.", nameof(book));

            if (string.IsNullOrWhiteSpace(book.Title))
                throw new ArgumentException("The book title cannot be null or empty.", nameof(book));

            if (string.IsNullOrWhiteSpace(book.Author))
                throw new ArgumentException("The author of the book (Author) cannot be null or empty.", nameof(book));

            var actualList = _bookRepository.GetAll();

            ValidateBookKeyFormat(book.BookKey);

            if (actualList.Any(existingBook =>
                    existingBook.BookKey == book.BookKey))
            {
                throw new InvalidOperationException("This book is already registered.");
            }
            _bookRepository.AddBook(book);
        }

        // Output books.

        public IReadOnlyCollection<Book> AllBooks()
        {
            var actualList = _bookRepository.GetAll();
            if(actualList.Count == 0)
            {
                throw new InvalidOperationException("A list is empty!");
            }
            return actualList;
        }

        public void ValidateBookKeyFormat(string bookKey)
        {
            bool isValid = Regex.IsMatch(bookKey, @"^BK\d{3}$");

            if (!isValid)
            {
                throw new FormatException("The code does not match the template");
            }
        }

    }
}
