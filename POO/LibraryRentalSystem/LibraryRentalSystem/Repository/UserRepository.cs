using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryRentalSystem.Entities;

namespace LibraryRentalSystem.Repository
{
    internal class UserRepository
    {
        private SortedSet<User> UsersCollection { get; set; } = new SortedSet<User>();

        private int _contId = 1;

        public void AddUser(User user)
        {
            user.Id = _contId++;
            UsersCollection.Add(user);
        }

        public IReadOnlyCollection<User> GetAllUser()
        {
            return UsersCollection;
        }

        // Get user by ID

        public User GetUserById(int id)
        {
            foreach(var user in UsersCollection)
            {
                if(user.Id == id) return user;
            }
            return null;
        }
    }
}
