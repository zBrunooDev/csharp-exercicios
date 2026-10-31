using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryRentalSystem.Entities
{
    internal class LoanBook
    {
        private static int loanBookId = 1;
        public int LoanBookId { get; set; }
        public Book Book { get; set; }
        public User User { get; set; }
        public DateTime LoanDate { get; set; }
        public TimeSpan? LoanDuration { get; private set; }
        public DateTime? ReturnDate { get; private set; }
        public LoanBook(User user, Book book, DateTime loanDate)
        {
            User = user ?? throw new ArgumentNullException(nameof(user));
            Book = book ?? throw new ArgumentNullException(nameof(book));
            LoanDate = loanDate;
            ReturnDate = null;
            LoanDuration = null;
            LoanBookId = loanBookId;
            loanBookId++;
        }
        public void RegisterReturn(DateTime returnDate)
        {
            if (returnDate < LoanDate)
            {
                throw new ArgumentException("The return date cannot be earlier than the loan date.", nameof(returnDate));
            }

            ReturnDate = returnDate;
            LoanDuration = returnDate - LoanDate;
        }
    }
}
