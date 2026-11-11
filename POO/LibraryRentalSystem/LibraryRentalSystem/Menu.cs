using System;
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
                if (chose < 0 || chose > 6)
                {
                    Console.WriteLine("Invalid option!");
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
                            Console.WriteLine("Shutting down the system...");
                            running = false;
                            break;
                    }
                }
            }
        }
        public void Display()
        {
            Console.WriteLine();

            Console.WriteLine("Library Rental System");
            Console.WriteLine();
            Console.WriteLine("============================================");
            Console.WriteLine("[1] Register a Book - valid format [BK001]");
            Console.WriteLine("[2] Register a User - Letters only.");
            Console.WriteLine("[3] View Books");
            Console.WriteLine("[4] Borrow a Book.");
            Console.WriteLine("[5] Return a Book");
            Console.WriteLine("[6] View Loan History.");
            Console.WriteLine("[0] Exit");
            Console.WriteLine("============================================");
            Console.Write("Choose an option: ");

        }
        int OptionEntry()
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

        void BookRegistration()
        {
            try
            {
                Console.Write("Enter the book code: ");
                string key = Console.ReadLine();
                Console.Write("Enter the book title: ");
                string title = Console.ReadLine();
                Console.Write("Author: ");
                string author = Console.ReadLine();

                Book book = new Book(key, title, author);
                _bookService.AddBookInLibrary(book);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        void UserRegister()
        {
            try
            {
                Console.Write("Enter your username: ");
                string name = Console.ReadLine();
                User user = new User(name);
                _userService.RegisterUser(user);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
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
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        void LoanBookRegister()
        {
            try
            {
                Console.Write("Enter the user ID: ");

                if (!int.TryParse(Console.ReadLine(), out int user))
                {
                    Console.WriteLine("Invalid user ID.");
                    return;
                }
                Console.Write("Enter the book code: ");
                string bookKey = Console.ReadLine();

                _loanBookService.Loan(user, bookKey);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        void LoanBookReturn()
        {
            try
            {
                Console.Write("Enter the user ID: ");

                if (!int.TryParse(Console.ReadLine(), out int user))
                {
                    Console.WriteLine("Invalid user ID.");
                    return;
                }
                Console.Write("Enter the book code: ");
                string bookKey = Console.ReadLine();

                _loanBookService.ReturnLoanBook(user, bookKey);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        void LoanHistory()
        {
            var listLoan = _loanBookService.GetAllLoans();

            if (listLoan.Count == 0)
            {
                Console.WriteLine("No loans have been registered.");
            }
            else
            {
                foreach (var item in listLoan)
                {
                    Console.WriteLine(item.Value.ToString());
                }
            }
        }
    }
}

