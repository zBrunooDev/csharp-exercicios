using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Com base na tabela de preços ao lado, faça
            um programa que leia o código de um item e a
            quantidade deste item. A seguir, calcule e
            mostre o valor da conta a pagar.*/

            string[] vet = Console.ReadLine().Split(' ');
            int codigo = int.Parse(vet[0]);
            int quantidade = int.Parse(vet[1]);

            double soma = 0;

            switch (codigo)
            {

                // basicamente é a tabela de preços
                case 1:
                    //Cachorro Quente
                    soma = quantidade * 4.00;
                    break;
                case 2:
                    //X-Salada
                    soma = quantidade * 4.50;
                    break;
                case 3:
                    //X-Bacon
                    soma = quantidade * 5.00;
                    break;
                case 4:
                    //Torrada simples
                    soma = quantidade * 2.00;
                    break;
                case 5:
                    //Refrigerante
                    soma = quantidade * 1.50;
                    break;
            }

            Console.WriteLine($"Total: R$ {soma:F2}");


        }
    }
}
