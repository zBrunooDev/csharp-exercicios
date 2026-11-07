using System;
using LibraryRentalSystem.Repository;
using LibraryRentalSystem.Entities;
using System.Text.RegularExpressions;
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
            ValidateUserNameFormat(user.Name);

            if (string.IsNullOrEmpty(user.Name))
            {
                throw new ArgumentNullException("The field cannot be null or empty!");
            }
            _userRepository.AddUser(user);
        }

        public void ValidateUserNameFormat(string name)
        {
            bool isValid = Regex.IsMatch(name, @"^[a-zA-Z]+$");

            if (!isValid)
            {
                throw new FormatException("The user name does not match the template");
            }
        }
    }
}
