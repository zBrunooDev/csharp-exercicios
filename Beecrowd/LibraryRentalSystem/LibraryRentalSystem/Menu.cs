using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryRentalSystem.Entities;
using LibraryRentalSystem.Repository;
using LibraryRentalSystem.Service;

namespace LibraryRentalSystem
{

    internal class Menu
    {

        private BookRepository _bookRepository;
        private BookService _bookService;
        public void Start()
        {
            _bookRepository = new BookRepository();
            _bookService = new BookService(_bookRepository);

            while (true)
            {
                Display();
                int chose = OptionEntry();
                switch (chose)
                {
                    case 1:
                        BookRegistration();
                        continue;
                    case 2:
                        break;
                }
            }
        }
        public void Display()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("Escolha as opções: ");
            Console.WriteLine("(1) Cadastrar Livro: ");
            Console.WriteLine("(2) Consultar Livros disponiveis: ");
            Console.WriteLine("(3) Conultar Livros emprestados: ");
            Console.WriteLine("(4) Devolver Livro: ");

            Console.WriteLine();

        }
        int OptionEntry()
        {
            try
            {
                int option = int.Parse(Console.ReadLine());
                return option;
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
            
        }

        void BookRegistration()
        {
            try
            {
                Console.Write("Digite o código do livro: ");
                string key = Console.ReadLine();
                Console.Write("Digite o nome do Livro: ");
                string title = Console.ReadLine();
                Console.Write("Author: ");
                string author = Console.ReadLine();

                Book book = new Book(key, title, author);
                _bookService.AddBookInLibrary(book);
            }
            catch(Exception e)
            {
                Console.WriteLine($"{e.Message}");
            }
        }
    }
}
