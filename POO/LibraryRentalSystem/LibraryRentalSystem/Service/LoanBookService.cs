using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryRentalSystem.Repository;
using LibraryRentalSystem.Entities;

namespace LibraryRentalSystem.Service
{
    internal class LoanBookService
    {
        private readonly UserRepository _userRepository;
        private readonly BookRepository _bookRepository;

        private readonly LoanBookRepository _loanBookRepository;

        public LoanBookService(UserRepository userRepository, BookRepository bookRepository, LoanBookRepository loanBookRepository)
        {
            _userRepository = userRepository;
            _bookRepository = bookRepository;
            _loanBookRepository = loanBookRepository;
        }

       
        public void Loan(User user, Book book)
        {

            ValidateUser(user);
            ValidateBook(book);
            CheckAvailability(book);

            LoanBook loanBook = new LoanBook(user, book, DateTime.Now);

            // Register loan

            _loanBookRepository.AddLoanBook(loanBook.LoanBookId, loanBook);
        }

        // User validation
        void ValidateUser(User user)
        {

            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            var actualListUser = _userRepository.GetAllUser();

            if (actualListUser == null || !actualListUser.Any())
            {
                throw new InvalidOperationException("The user list is empty.");
            }
            if(!(actualListUser.Contains(user)))
            {
                throw new Exception("The user is not registered.");
            }

        }

        // Book validation
        void ValidateBook(Book book)
        {

            if (book == null)
            {
                throw new ArgumentNullException(nameof(book));
            }

            var actualListBook = _bookRepository.GetAll();

            if (actualListBook == null || !actualListBook.Any())
            {
                throw new InvalidOperationException("The book list is empty.");
            }
            if (!(actualListBook.Contains(book)))
            {
                throw new Exception("The book is not registered.");
            }

        }

        // Check availability

        public void CheckAvailability(Book book)
        {
            var borrowedBooks = _loanBookRepository.GetAllLoanBooks();

            if (borrowedBooks == null)
            {
                throw new Exception("The loan list is null.");
            }

            if (borrowedBooks.Any(loan => loan.Value.Book.BookKey == book.BookKey && loan.Value.ReturnDate == null))
            {
                throw new Exception("The book is already on loan.");
            }
        }     
    }
}
