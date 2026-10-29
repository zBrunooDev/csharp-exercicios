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

        public LoanBookService(UserRepository userRepository, BookRepository bookRepository)
        {
            _userRepository = userRepository;
            _bookRepository = bookRepository;
        }

       
        public void Loan(User user, Book bookKey)
        {

            ValidateUser(user);

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
                throw new ArgumentNullException("The list is empty.");
            }
            if(!(actualListUser.Contains(user)))
            {
                throw new Exception("The user is not registered.");
            }

        }

        // Book validation
        // Check availability
        // Register loan
    }
}
