using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryRentalSystem.Entities;

namespace LibraryRentalSystem.Repository
{
    internal class Users
    {
        public SortedSet<User> UsersList { get; set; } = new SortedSet<User>();

        public void AddUser(User user)
        {
            UsersList.Add(user);
        }
    }
}
