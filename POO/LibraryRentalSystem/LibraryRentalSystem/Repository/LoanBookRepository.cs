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

        public void AddLoanBook(int loanKey, LoanBook loanBook)
        {
            LoanBookCollection.Add(loanKey, loanBook);
        }

        public Dictionary<int, LoanBook> GetAllLoanBooks()
        {
            return LoanBookCollection;
        }

    }
}
