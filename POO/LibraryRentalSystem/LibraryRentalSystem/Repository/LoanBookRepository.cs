using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryRentalSystem.Entities;

namespace LibraryRentalSystem.Repository
{
    internal class LoanBookRepository
    {
        private Dictionary<int, LoanBook> LoanBookCollection { get; set; } = new Dictionary<int, LoanBook>();
        private int _loanBookId = 1;

        public void AddLoanBook(LoanBook loanBook)
        {
            loanBook.LoanBookId = _loanBookId++;

            LoanBookCollection.Add(loanBook.LoanBookId, loanBook);
        }

        public IReadOnlyDictionary<int, LoanBook> GetAllLoanBooks()
        {
            return LoanBookCollection;
        }

        public void ReturnBook(int IdLoan)
        {
            LoanBookCollection[IdLoan].RegisterReturn();
        }


    }
}
