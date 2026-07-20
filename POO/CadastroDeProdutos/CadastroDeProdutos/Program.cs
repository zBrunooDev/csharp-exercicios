using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeProdutos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> produtos = new List<int>();

            Console.WriteLine("=== Cadastro de Produtos ===");

            Console.WriteLine("" +
                "1 - Cadastrar produto\r\n" +
                "2 - Listar produtos\r\n" +
                "3 - Buscar produto\r\n" +
                "4 - Atualizar estoque\r\n" +
                "5 - Remover produto\r\n" +
                "0 - Sair");

            int opcao = int.Parse(Console.ReadLine());

            do
            {
                switch (opcao)
                {
                    case 1:

                        break;
                }

            }while(true);

        }

        public void CadastrarProduto()
        {
            Console.WriteLine("");
        }
    }
}
