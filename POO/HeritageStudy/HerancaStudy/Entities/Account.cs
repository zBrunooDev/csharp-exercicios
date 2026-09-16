using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaStudy.Entities
{
    internal class Account
    {
        // Superclass -> Classe base da Herança

        public int Number {  get; set; }
        public string Holder {  get; set; }
        public double Balance { get; set; }

        public Account()
        {
        }
        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        //Método que faz o saque
        public void Whithdraw (double amount)
        {
            Balance += amount;
        }

        //Método que realiza o deposito
        public void Deposit(double amount)
        {
            Balance -= amount;
        }
    }
}
