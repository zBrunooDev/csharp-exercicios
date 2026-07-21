using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeProdutos
{
    internal class Program
    {

        static List<Produto> produtos = new List<Produto>();
        static int contId = 1;

        static void Main(string[] args)
        {
            Menu();
        }

        public static void Menu()
        {

            Console.WriteLine("=== Cadastro de Produtos ===\r\n");

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
                        Menu();
                        break;
                    case 2:
                        ListarProduto();
                        Menu();
                        break;
                    case 3:
                        BuscarPorId();
                        Menu();
                        break;
                }

            } while (opcao != 0);
        }

        public static void CadastrarProduto()
        {
            
            Produto produto = new Produto();
            produto.Id = contId;
            contId++;
            
            Console.WriteLine("Digite o nome do Produto: ");
            produto.Nome = Console.ReadLine();
            Console.WriteLine("Digite o preço do Produto: ");
            produto.Preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade do Produto: ");
            produto.Quantidade = int.Parse(Console.ReadLine());

            produtos.Add(produto);
            Console.WriteLine("Produto cadastrado!");
            
        }

        public static void ListarProduto()
        {
            if(produtos.Count == 0)
            {
                Console.WriteLine("Nenhum Produto cadastrado!");
            }
            else
            {
                foreach(Produto produto in produtos)
                {
                    Console.WriteLine($"Id: {produto.Id}, Nome: {produto.Nome}, R$ {produto.Preco}, Quantidade: {produto.Quantidade}");
                }
            }

        }

        public static void BuscarPorId()
        {
            Console.Write("Digite código do produto (Id): ");
            int procurarId = int.Parse(Console.ReadLine());

            foreach(Produto produto in produtos)
            {
                if( produto.Id == procurarId)
                {
                    Console.WriteLine($"Id: {produto.Id}, Nome: {produto.Nome}, R$ {produto.Preco}, Quantidade: {produto.Quantidade}");
                }
            }
            
        }
    }
}
