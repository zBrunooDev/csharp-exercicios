using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryRentalSystem.Repository;
using LibraryRentalSystem.Entities;

namespace LibraryRentalSystem.Service
{
    internal class UserService
    {

        private readonly UserRepository _userRepository;

        public UserService(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        // Add User

        public void RegisterUser(User user)
        {
            if (string.IsNullOrEmpty(user.Name))
            {
                throw new ArgumentNullException("The field cannot be null or empty!");
            }
            _userRepository.AddUser(user);
        }
    }
}
