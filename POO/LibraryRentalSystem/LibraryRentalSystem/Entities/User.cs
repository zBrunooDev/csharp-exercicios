using System;

namespace LibraryRentalSystem.Entities
{
    internal class User : IComparable<User>
    {
        public int Id { get; internal set; }
        public string Name { get; private set; }

        public User(string name)
        {
            Name = name;
        }

        public int CompareTo(User other)
        {
            if (other is null)
                return 1;

            return Id.CompareTo(other.Id);
        }
    }
}
