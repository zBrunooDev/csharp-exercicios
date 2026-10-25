using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using LibraryRentalSystem.Repository;
using LibraryRentalSystem.Service;

namespace LibraryRentalSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();

            menu.Start();

        }
    }
}
