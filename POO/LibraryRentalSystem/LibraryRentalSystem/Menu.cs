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
        private LoanBookRepository _loanBookRepository;
        private LoanBookService _loanBookService;

        public void Start()
        {
            _bookRepository = new BookRepository();
            _bookService = new BookService(_bookRepository);

            _userRepository = new UserRepository();
            _userService = new UserService(_userRepository);

            _loanBookRepository = new LoanBookRepository();
            _loanBookService = new LoanBookService(_userRepository, _bookRepository, _loanBookRepository);
            bool running = true;

            while (running)
            {
                Display();
                int chose = OptionEntry();
                if(chose  == -1 || chose > 6)
                {
                    Console.WriteLine("Opção errada!");
                }
                else
                {
                    switch (chose)
                    {
                        case 1:
                            BookRegistration();
                            continue;
                        case 2:
                            UserRegister();
                            continue;
                        case 3:
                            ViewAvailables();
                            continue;
                        case 4:
                            LoanBookRegister();
                            continue;
                        case 5:
                            LoanBookReturn();
                            continue;
                        case 6:
                            LoanHistory();
                            continue;
                        case 0:
                            Console.WriteLine("Encerrando o sistema...");
                            running = false;
                            break;
                    }
                }
            }
        }
        public void Display()
        {
            Console.WriteLine();

            Console.WriteLine("Loan Book Service");
            Console.WriteLine();
            Console.WriteLine("============================================");
            Console.WriteLine("[1] Cadastrar Livro - formato valido [BK001]");
            Console.WriteLine("[2] Cadastrar usuário");
            Console.WriteLine("[3] Consultar Livros");
            Console.WriteLine("[4] Pegar um livro emprestado.");
            Console.WriteLine("[5] Devolver Livro");
            Console.WriteLine("[6] Mostrar Histórico de Empréstimos.");
            Console.WriteLine("[0] Sair");
            Console.WriteLine("============================================");
            Console.Write("Escolha uma opção: ");

        }
        int OptionEntry()
        {
            {
                string input = Console.ReadLine();

                int option;
                bool isNumber = int.TryParse(input, out option);

                if (isNumber)
                {
                    return option;
                }
                return -1;
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
            try
            {
                var actuaList = _bookService.AllBooks();
                foreach (var item in actuaList)
                {
                    Console.WriteLine(item);
                }
            }
            catch( Exception e ) 
            {
                Console.WriteLine($"{e.Message}");
            }        
        }

        void LoanBookRegister()
        {
            try
            {
                Console.Write("Digite o ID do usuário: ");
                int user = int.Parse(Console.ReadLine());
                Console.Write("Digite o codigo do livro: ");
                string bookKey = Console.ReadLine();

                _loanBookService.Loan(user, bookKey);
            }
            catch(Exception e)
            { 
                Console.WriteLine(e);
            }
        }

        void LoanBookReturn()
        {
            try
            {
                Console.Write("Digite o ID do usuário: ");
                int user = int.Parse(Console.ReadLine());
                Console.Write("Digite o codigo do livro: ");
                string bookKey = Console.ReadLine();

                _loanBookService.ReturnLoanBook(user, bookKey);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        void LoanHistory()
        {
            var listLoan = _loanBookRepository.GetAllLoanBooks();

            if(listLoan.Count == 0)
            {
                Console.WriteLine("Não há empréstimo cadastrado;");
            }
            else
            {
                foreach (var item in listLoan)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
