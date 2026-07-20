using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeProdutos
{
    internal class Program
    {

        static List<Produto> produtos = new List<Produto>();

        static void Main(string[] args)
        {
            

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
                        CadastrarProduto();
                        break;
                }

            }while(true);

        }

        public static void CadastrarProduto()
        {
            Produto produto = new Produto();
            
            Console.WriteLine("Digite o nome do Produto: ");
            produto.Nome = Console.ReadLine();
            Console.WriteLine("Digite o preço do Produto: ");
            produto.Preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade do Produto: ");
            produto.Quantidade = int.Parse(Console.ReadLine());

            produtos.Add(produto);
        }
    }
}
