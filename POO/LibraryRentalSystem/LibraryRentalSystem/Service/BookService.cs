using System;
using System.Collections.Generic;
using System.Linq;
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
            var actualList = _bookRepository.GetAll();

            if(actualList.Contains(book))
            {
                throw new Exception("This book is already registered.");
            }
            _bookRepository.AddBook(book);
        }
    }
}
