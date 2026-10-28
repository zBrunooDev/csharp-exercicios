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
        private UserRepository _userRepository;
        private UserService _userService;
        public void Start()
        {
            _bookRepository = new BookRepository();
            _bookService = new BookService(_bookRepository);
            _userRepository = new UserRepository();
            _userService = new UserService(_userRepository);

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
                        UserRegister();
                        break;
                }
            }
        }
        public void Display()
        {
            Console.WriteLine("------------Menu------------\n");
            Console.WriteLine("Escolha as opções");
            Console.WriteLine("(1) Cadastrar Livro");
            Console.WriteLine("(2) Cadastrar usuário");
            Console.WriteLine("() Consultar Livros disponiveis");
            Console.WriteLine("() Conultar Livros emprestados");
            Console.WriteLine("() Devolver Livro");

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

        void UserRegister()
        {
            try 
            {
                Console.Write("Digite seu nome de usuário: ");
                string name = Console.ReadLine();
                User user = new User(name);
                _userService.RegisterUser(user);
            }
            catch(Exception e)
            {
                Console.WriteLine($"{e.Message}");
            }
            
        }

        void ViewAvailables()
        {

        }


    }
}
