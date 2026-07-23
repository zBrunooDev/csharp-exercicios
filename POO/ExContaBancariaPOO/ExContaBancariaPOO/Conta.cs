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
        public string Nome { get ; set; }

        public Conta(int numeroConta, string nome)
        {
            NumeroConta = numeroConta;
            Nome = nome;
        }

        public Conta(int numeroConta,  string nome, double saldoInicial) : this(numeroConta, nome)
        {
            Saldo = saldoInicial;
            Deposito(saldoInicial);
        }

        public void Deposito(double deposito)
        {
            Saldo += deposito;
        }

        public void Saque(double saque)
        {
            Saldo -= 5.00;
            Saldo -= saque;
        }

        public override string ToString()
        {
            return $"Conta {NumeroConta}, Titular: {Nome}, Saldo: $ {Saldo:F2}";
        }

    }
}
