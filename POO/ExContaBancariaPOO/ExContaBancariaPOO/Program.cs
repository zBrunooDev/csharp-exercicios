using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExContaBancariaPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Entre o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());
            Console.Write("Entre o títular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá deposito inicial? (s/n) ");
            string escolha = Console.ReadLine();

            Conta conta = new Conta(numeroConta, nome);

            if (escolha == "s")
            {
                Console.Write("Entre o valor de depósito incial: ");
                double saldoInicial = double.Parse(Console.ReadLine());
                conta.DepositoInicial(saldoInicial);
            }

            Console.WriteLine("Dados da Conta: ");
            Console.WriteLine(conta);

            Console.Write("Entre um valor de depósito: ");

            

        }
    }
}
