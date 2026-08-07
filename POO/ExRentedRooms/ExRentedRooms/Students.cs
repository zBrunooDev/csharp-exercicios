using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExRentedRooms
{
    internal class Students
    {
        public string Name {  get; set; }
        public string Email { get; set; }
        public Students (string nome,  string email)
        {
            Name = nome;
            Email = email;
        }
        public override string ToString()
        {
             return Name + " " + Email;
        }

    }
}
