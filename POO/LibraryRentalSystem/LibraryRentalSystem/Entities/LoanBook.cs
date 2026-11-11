using System;
using System.Text;

namespace LibraryRentalSystem.Entities
{
    internal class LoanBook
    {
        public int LoanBookId { get; internal set; }
        public Book Book { get; private set; }
        public User User { get; private set; }
        public DateTime LoanDate { get; private set; }
        public TimeSpan? LoanDuration { get; private set; }
        public DateTime? ReturnDate { get; private set; }
        public LoanBook(User user, Book book, DateTime loanDate)
        {
            User = user ?? throw new ArgumentNullException(nameof(user));
            Book = book ?? throw new ArgumentNullException(nameof(book));
            LoanDate = loanDate;
            ReturnDate = null;
            LoanDuration = null;
        }
        public void RegisterReturn()
        {
            if (ReturnDate.HasValue)
            {
                throw new InvalidOperationException("This book has already been returned.");
            }

            DateTime returnDate = DateTime.Now;

            if (returnDate < LoanDate)
            {
                throw new ArgumentException("The return date cannot be earlier than the loan date.", nameof(returnDate));
            }

            ReturnDate = returnDate;
            LoanDuration = returnDate - LoanDate;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"_________________________________________________________________________________________");
            sb.AppendLine($"Loan ID: {LoanBookId}");
            sb.AppendLine($"Book: {Book.Title} - ID: {Book.BookKey}");
            sb.AppendLine($"User: {User.Name} - ID: {User.Id}");
            if(ReturnDate != null) sb.AppendLine($"Initial: {LoanDate:HH:mm - dd/MM/yyyy} and Return: {ReturnDate:HH:mm - dd/MM/yyyy}");
            else sb.AppendLine($"Initial: {LoanDate:HH:mm - dd/MM/yyyy} and Return: The book has not yet been returned. ");
            sb.AppendLine($"Duration: {LoanDuration}");
            sb.AppendLine($"_________________________________________________________________________________________");

            return sb.ToString();
        }
    }
}
