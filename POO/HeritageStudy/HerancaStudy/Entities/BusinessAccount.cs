using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaStudy.Entities
{
    internal class BusinessAccount : Account // -> Esses dois pontos é uma operaçãao de herança. "BusinessAccount é uma Account"
    {
        // É nesse momento que as propriedades de BussinesAccount sejam herdadas de Account.

        public double LoanLimit { get; set; } // Aqui eu posso criar outras propriedade que serão apenas dessa subclasse.

        public BusinessAccount() { }

        // Aqui o construtor pode receber os paramentros de entrada do construtor da da  Superclass. Aapenaas utilizando a palavra base.
        public BusinessAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance)
        {
            // Agora aqui eu não preciso refazer todos os elementos da classe receberem os valores dos parâmetros novamente, posso reutilizar-los do contrutor da classe base;
            // Só preciso fazer isso com o novo elemento.

            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            // Suponha que, para realizar um empréstimo, é descontada uma taxa no valor de 10.0

            if (amount <= LoanLimit)
            {
                Balance += amount - 10.0;
            }
        }

    }
}
