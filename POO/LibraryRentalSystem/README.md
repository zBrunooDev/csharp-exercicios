# 📚 LibraryRentalSystem

🇧🇷 [Versão em português](README.md)

A **C#** console application for managing book rentals in a library or bookstore. The system is operated by a staff member, who registers books and users, records loans and returns, and checks the loan history.

The project started as an exercise to practice **C# collections** and grew into an application organized in layers, with validations, business rules, and **38 documented test cases**.

> **Status:** V1 completed. Next steps are listed in the [Roadmap](#-roadmap).

---

## ✨ Features

- **Book registration** with a code in the `BK001` format, a title, and an author. Duplicate codes are rejected.
- **User registration** (letters only). Each user gets a unique ID generated automatically.
- **Book listing** in alphabetical order (by title and, on a tie, by code).
- **Loans** by user ID and book code.
- **Returns** with the date/time and the loan duration recorded automatically.
- **Loan history** showing the loan date, return date, and duration of each record.

## 📏 Business rules

- Both the user and the book must be registered before a loan can happen.
- A book that is already on loan cannot be lent to anyone (including the same person) until it is returned.
- A return is only accepted for an active loan of the same user and the same book.
- Once returned, a book can be borrowed again. Each loan creates a new record and the previous history is preserved.
- A book code that does not follow the `BK` + 3 digits pattern (e.g., `BK001`) is rejected.

## 🖥️ Menu

```text
Library Rental System

============================================
[1] Register a Book - valid format [BK001]
[2] Register a User - Letters only.
[3] View Books
[4] Borrow a Book.
[5] Return a Book
[6] View Loan History.
[0] Exit
============================================
Choose an option:
```

## 🏗️ Architecture

The code is split into layers, each with a single responsibility:

```text
LibraryRentalSystem/
├── Entities/      # Book, User, LoanBook (domain model)
├── Repository/    # in-memory storage for each entity
├── Service/       # business rules and validations
├── Menu.cs        # console interface
├── Program.cs     # entry point
└── TESTS.md       # documented test cases
```

- **Entities:** `Book` and `User` implement `IComparable` for sorting; `LoanBook` holds the user, the book, the loan date, the return date, and the duration.
- **Repository:** `SortedSet<Book>` and `SortedSet<User>` keep the data sorted; a `Dictionary<int, LoanBook>` stores the loans by ID.
- **Service:** centralizes the validations (book code format with `Regex`, letters-only user names, book availability) and throws a specific exception for each error.
- **Manual dependency injection:** repositories are created in `Menu` and passed to the services through their constructors.

## 🛠️ Tech stack

- C#
- .NET Framework 4.7.2
- Console application
- Visual Studio

## ▶️ Getting started

1. Clone the repository:
   ```bash
   git clone https://github.com/zBrunooDev/csharp-exercicios.git
   ```
2. Open the `LibraryRentalSystem.slnx` file (inside the project folder) in Visual Studio.
3. Run with **F5** (or **Ctrl + F5** to run without debugging).

> In V1 the data is kept in memory only: when the program exits, all registrations and loans are lost.

## ✅ Tests

The V1 tests were run **manually** and documented in [`TESTS.md`](LibraryRentalSystem/TESTS.md): **38 cases, all passing**, split into 6 modules:

| Module | Focus |
| --- | --- |
| 01 | Book registration |
| 02 | User registration |
| 03 | Book loans |
| 04 | Book returns |
| 05 | Loan history and availability |
| 06 | Robustness tests (invalid input) |

## 🧠 Concepts practiced

- Object-oriented programming (encapsulation, composition, `IComparable`)
- Generic collections (`SortedSet`, `Dictionary`, `IReadOnlyCollection`)
- Layered design (Entities, Repository, Service)
- Validation with regular expressions
- Exception handling
- Writing and running documented test cases

## 🗺️ Roadmap

- [ ] Automated unit tests
- [ ] Migration to a modern version of .NET
- [ ] Database persistence with Entity Framework
- [ ] Loan history filtered by book and by user, and an availability indicator in the book listing
- [ ] REST API
- [ ] Web interface

## 👤 Author

**Bruno Lima da Silva**

[LinkedIn](https://www.linkedin.com/in/brunolima513) · [GitHub](https://github.com/zBrunooDev)
