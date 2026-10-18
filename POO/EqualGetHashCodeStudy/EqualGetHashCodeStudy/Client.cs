using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualGetHashCodeStudy
{
    internal class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }

        // Overrides the Equals method in the Client class.
        // We choose the property used to compare objects with Equals.
        public override bool Equals(object obj)
        {
            if(!(obj is Client)) // Checks whether the object is a Client.
            {
                return false;
            }
            Client other = obj as Client; // Downcasting.
            return Email.Equals(other.Email); // Uses the Equals method.
        }

        // Overrides the GetHashCode method.

        public override int GetHashCode()
        {
            return Email.GetHashCode();
        }


    }
}
