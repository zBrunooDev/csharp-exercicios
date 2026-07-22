using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExContaBancariaPOO
{
    internal class Conta
    {
        private int NumeroConta;
        private double Saldo {  get; }
        public string Nome;

        public Conta(int numeroConta, double saldo, string nome)
        {
            NumeroConta = numeroConta;
            Saldo = saldo;
            Nome = nome;
        }

        public double Deposito(double deposito)
        {
            return deposito + Saldo;
        }

    }
}
