using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WithdrawalLimit.Entities;

namespace WithdrawalLimit
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double initialBalance = double.Parse(Console.ReadLine());
                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine());

                Account account = new Account(number, holder, withdrawLimit);
                account.Deposit(initialBalance);

                Console.Write("Enter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine());

                account.Withdraw(amount);

                Console.WriteLine("New balance: " + account.Balance);
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Withdraw error: {ex.Message}");
            }
        }
    }
    
}
