using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryRentalSystem.Entities
{
    internal class User : IComparable
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        private static int _contId = 1;

        public User(string name)
        {
            Name = name;
            Id = _contId;
            _contId++;
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
