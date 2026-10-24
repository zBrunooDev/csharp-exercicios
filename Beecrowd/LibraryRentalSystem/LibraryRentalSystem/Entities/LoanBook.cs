using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryRentalSystem.Entities
{
    internal class LoanBook
    {
        public Dictionary<Book, User> BookHolders { get; set; }

    }
}
