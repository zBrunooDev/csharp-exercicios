using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualGetHashCodeStudy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Here, we have two objects with different email addresses.
            Client a = new Client { Name = "Maria", Email = "maria123@gmail.com" };
            Client b = new Client { Name = "Jose", Email = "jose456@gmail.com" };


            // The output is:
            Console.WriteLine(a.Equals(b)); // False. If the email addresses were equal, it would return true.
            Console.WriteLine(a.GetHashCode()); // Returns the hash code of object a.
            Console.WriteLine(b.GetHashCode()); // Returns the hash code of object b.

        }
    }
}
