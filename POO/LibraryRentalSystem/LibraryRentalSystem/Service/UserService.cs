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
            if (user == null)
                throw new ArgumentNullException(nameof(user));

            if (string.IsNullOrWhiteSpace(user.Name))
                throw new ArgumentException("The user name cannot be null or empty.");

            ValidateUserNameFormat(user.Name);

            _userRepository.AddUser(user);
        }

        public void ValidateUserNameFormat(string name)
        {
            bool isValid = Regex.IsMatch(name, @"^\p{L}+$");

            if (!isValid)
            {
                throw new FormatException("The user name does not match the template");
            }
        }
    }
}
