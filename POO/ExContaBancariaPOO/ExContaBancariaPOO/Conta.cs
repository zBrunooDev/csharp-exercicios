using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExContaBancariaPOO
{
    internal class Conta
    {
        public int NumeroConta { get; private set; }
        public double Saldo { get; private set; }
        public string Nome;

        public Conta(int numeroConta, string nome)
        {
            NumeroConta = numeroConta;
            Nome = nome;
        }

        public double DepositoInicial(double depositoInicial)
        {
            return Saldo = depositoInicial;
        }

        public double Deposito(double deposito)
        {
            return deposito + Saldo;
        }

    }
}
