using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LibraryRentalSystem.Entities
{
    internal class Book
    {
        public string BookKey { get; private set; }
        public string Title { get; private set; }
        public string Author { get; private set; }

        public Book(string bookKey, string title, string author)
        {
            BookKey = bookKey;
            Title = title;
            Author = author;
        }
    }
}
