## Module 01 - Book Registration

## Test 01 - Register book with code BK001

Input:
BookKey - BK001
Book Name - Lords of the Rings - The Fellowship of the Ring
Author: JJR Tolkien

Expected:
- Register the book normally.

Result:
- 🟢 Passed


Observation:
- The book was registered normally.

## Test 02 - Register another book with code BK001


Input:
BookKey - BK001
Book Name - Test02
Author: Test

Expected:
- This shows that the book with code BK001 is already registered.


Result:
- 🟢 Passed


Observation:
- The system identified that the book code had already been registered.

## Test 03 - Register book with code BK002 and another title.


Input:
BookKey - BK002
Book Name - The Stranger
Author: Albert Camus


Expected:
- Register the book normally.

Result:
- 🟢 Passed

Observation: 
- The book was registered normally.

## Test 04 - Consult all books.

Input:
- Order books: 3

Expected:
- Show the list of registered books regardless of whether they are checked out or not.

Result:
- 🟢 Passed

Observation:
- Displays the registered books in alphabetical order.

## Test 05 - Register book with empty code.

Input:
- BookKey - "Empty" 

Expected:
- Reject invalid input

Result:
- 🔴 Failed - Needs correction

Observation:
- I need to fix this validation so that it doesn't accept empty codes.

## Test 06 - Register a book with an empty title.

Input:
- Name Book: "Empty"

Expected:
- Reject invalid input

Result:
- 🔴 Failed - Needs correction

Observation:
- I need to fix this validation so that it doesn't accept empty names.


## Module 02 - User Registration

## Test 07 - User Register Bruno

Input:
- Option: 2
- User name: Bruno

Expected:
- Registration completed.

Result:
- 🟢 Passed

Observation:
- User registration completed normally.

## Test 08 - User Register Carlos

Input:
- Option: 2
- User name: Carlos

Expected:
- Registration completed.

Result:
- 🟢 Passed

Observation:
- User registration completed normally.

## Test 09 - Register another user named Bruno.

Input:
- Option: 2
- User name: Bruno

Expected:
- Check if the system allows duplicate names.

Result:
- 🟡 Pending
- Analyze whether it makes sense to maintain this behavior.

Observation:
- The system allows registration of users with the same names.

## Test 10 - Find a non-existent user.

Input:
- Option: 4 / 5
- ID user: 5 -> User inexistent

Expected:
- To inform that it was not found.

Result:
- 🟢 Passed

Observation:
- When attempting to borrow or return a book with a non-existent user ID entered, the system returns an exception.

## Module 03 - Book loan

## Test 11 - User 1 picks BK001

Input:
- User ID - 1
- BookKey - BK001

Expected:
- Loan taken out.

Result:
- 🟢 Passed

Observation:
- The Loan is complete normally

## Test 12 - User 1 tries to pick BK001 again

Input:
- User ID - 1
- BookKey - BK001


Expected:
- Prevent the loan operation.

Result:
- 🟢 Passed

Observation:
- The program identified that the typed book had already been borrowed.

## Test 13 - User 2 tries to pick BK001

Input:
- User ID - 2
- BookKey - BK001

Expected:
- Prevent the loan operation.

Result:
- 🟢 Passed

Observation:
- The program identified that the typed book had already been borrowed.

## Test 14 - User 2 picks BK002

Input:
- ID User: 2
- BookKey: BK002

Expected:
- Loan taken out.

Result:
- 🟢 Passed

Observation:
- Loan taken out normally.

## Test 15 - User 1 tries to pick a non-existent book (BK999)

Input:
- ID User: 1
- BookKey: BK999 -> inexistent

Expected:
- Reject the operation.

Result:
- 🟢 Passed

Observation:
- Operation rejected

## Test 16 - A non-existent user tries to pick BK001

Input:
- ID User: 8 -> inexistent
- BookKey: BK001

Expected:
- Reject the operation.

Result:
- 🟢 Passed

Observation:
- Operation rejected

## Test 17 - User 1 tries to pick BK002, which is borrowed by User 2

Input:
- ID User: 1
- BookKey: BK002


Expected:
- Prevent the loan operation.

Result:
- 🟢 Passed

Observation:
- The operation was rejected.

## Module 04 - Loan Books

## Test 18 - User 1 returns BK001

Input:
- ID User: 1
- BookKey: BK001


Expected:
- Book returned successfully.

Result:
- 🟢 Passed

Observation:
- Book returned successfully.

## Test 19 - User 1 tries to return BK001 again

Input:
- ID User: 1
- BookKey: BK001 -> Already returned

Expected:
- Reject the operation.

Result:
- 🟢 Passed

Observation:
- return: No active loan found for this user and book.

## Test 20 - User 1 borrows BK001 again

Input:
- ID User: 1
- BookKey: BK001

Expected:
- Loan taken out.

Result:
- 🟢 Passed

Observation:
- The book was borrowed

## Test 21 - User 2 tries to return BK001, which is borrowed by User 1

Input:
- ID User: 2
- BookKey: BK001

Expected:
- Reject the operation.

Result:
- 🟢 Passed

Observation:
- return: No active loan found for this user and book.

## Test 22 - User 1 returns BK001

Input:
- ID User: 1
- BookKey: BK001


Expected:
- Book returned successfully.

Result:
- 🟢 Passed

Observation:
- The book is returned normally.

## Test 23 - User 2 borrows BK001

Input:
- ID User: 2
- BookKey: BK001

Expected:
- Loan taken out.

Result:
- 🟢 Passed

Observation:
- The loan is successfully.

## Test 24 - User 1 tries to return BK001, which is now borrowed by User 2

Input:
- ID User: 1
- BookKey: BK001

Expected:
- Reject the operation.

Result:
- 🟢 Passed

Observation:
- return: No active loan found for this user and book.

## Test 25 - User 2 returns BK001

Input:
- ID User: 2
- BookKey: BK001

Expected:
- Book returned successfully.

Result:
- 🔴 Failed - Needs correction

Observation:
- The book cannot be returned even if it was borrowed by User 1.

## Test 26 - User 1 tries to return BK002 without ever having borrowed it

Input:
- ID User: 1
- BookKey: BK002

Expected:
- Reject the operation.

Result:
- 🟢 Passed

Observation:
- The system did not allow the operation.

## Test 27 - A non-existent user tries to return BK001

Input:
- ID User: 8 -> User inexistent
- BookKey: BK001

Expected:
- Reject the operation.

Result:
- 🟢 Passed

Observation:
- Operation rejected.

## Test 28 - Attempt to return a non-existent book (BK999)

Input:
- ID User: 2
- BookKey: BK999

Expected:
- Reject the operation.

Result:
- 🟢 Passed

Observation:
- Operation rejected.

## From here I need to modify the code to add some functionalities.

## Module 05 - Loan history and availability

## Test 29 - Return a book and check the loan records

Input:


Expected:
- Previous loan records must be preserved.

Result:


Observation:


## Test 30 - Borrow a book that has already been returned

Input:


Expected:
- A new loan record must be created.

Result:


Observation:


## Test 31 - Return the new loan

Input:


Expected:
- Only the correct loan record must be updated.

Result:


Observation:


## Test 32 - Try to borrow a book that is still on loan

Input:


Expected:
- Prevent the operation.

Result:


Observation:


## Test 33 - Return a book and lend it to another user

Input:


Expected:
- Allow the operation.

Result:


Observation:

## Module 06 - Robustness tests

## Test 34 - Enter a non-existent menu option (e.g., 9)

Input:


Expected:
- Display an invalid option message.

Result:


Observation:


## Test 35 - Enter letters when the menu expects a number

Input:


Expected:
- The application must not terminate unexpectedly.

Result:


Observation:


## Test 36 - Enter an empty ID

Input:


Expected:
- Reject the input.

Result:


Observation:


## Test 37 - Enter a BookKey containing spaces or unexpected characters

Input:


Expected:
- Handle invalid input.

Result:


Observation:


## Test 38 - Try to return a book with no registered loan

Input:


Expected:
- Reject the operation.

Result:


Observation: