using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace WithdrawalLimit.Entities
{
    internal class Account
    {
        public int Number { get; set; }
        public string Holder {  get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account (int number, string holder, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = 0;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
        public void Withdraw(double amount)
        {
            if(amount > WithdrawLimit)
            {
                throw new Exception("The ammount exceeds withdraw limit.");
            }
            if (amount > Balance)
            {
                throw new Exception("Not enought balance");
            }
            Balance -= amount;
        }
    }
}
