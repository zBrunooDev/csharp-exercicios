using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryRentalSystem.Entities
{
    internal class User : IComparable
    {
        public int Id { get; internal set; }
        public string Name { get; private set; }

        public User(string name)
        {
            Name = name;
        }

        public int CompareTo(object obj)
        {
            if (!(obj is User))
            {
                throw new ArgumentException("It does not correspond to the correct object type.");
            }
            User other = obj as User;
            return Id.CompareTo(other.Id);
        }

    }
}
