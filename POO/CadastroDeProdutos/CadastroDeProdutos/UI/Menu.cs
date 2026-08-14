using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using CadastroDeProdutos.Service;

namespace CadastroDeProdutos.UI
{
    public class Menu
    {
        static ProdutoService produtoService = new ProdutoService();

        public void Start()
        {
            bool running = true;
            while (running)
            {
                Display();
                int opcao = ReadOption("");
                if (opcao == -1)
                {
                    Console.WriteLine("opção invalida!");
                    continue;
                }
                else
                {
                    switch (opcao)
                    {
                        case 1:
                            CadastrarProduto();
                            break;
                        case 2:
                            ListarProduto();
                            break;
                        case 3:
                            BuscarPorId();
                            break;
                        case 5:
                            Delete();
                            break;
                    }
                }
            }
        }
        static void Display()
        {

            Console.WriteLine("=== Cadastro de Produtos ===\r\n");

            Console.WriteLine("" +
                "1 - Cadastrar produto\r\n" +
                "2 - Listar produtos\r\n" +
                "3 - Buscar produto\r\n" +
                "4 - Atualizar estoque\r\n" +
                "5 - Remover produto\r\n" +
                "0 - Sair");

            Console.Write("Digite a opção: ");
        }

        static void CadastrarProduto()
        {
            Console.WriteLine("Digite o nome do Produto: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o preço do Produto: ");
            double preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade do Produto: ");
            int quantidade = int.Parse(Console.ReadLine());

            produtoService.CadastrarProduto(nome, preco, quantidade);

            Console.WriteLine("Produto cadastrado!");
        }

        static void ListarProduto()
        {
            var produtos = produtoService.PegarTodos();
            if(produtos.Count == 0)
            {
                Console.WriteLine("Não há produtos cadastratos.");
                return;
            }
            foreach(Produto produto in produtos)
            {
                Console.WriteLine($"Produtos: {produto.Id}, {produto.Nome}, {produto.Preco:F2},{produto.Quantidade}");
            }
        }

        public static void BuscarPorId()
        {
            Console.WriteLine("Digite o ID: ");
            int id = int.Parse(Console.ReadLine());

            var produto = produtoService.GetProduto(id);

            Console.WriteLine($"Produtos: {produto.Id}, {produto.Nome}, {produto.Preco:F2},{produto.Quantidade}");

        }

        public static void Delete()
        {
            Console.Write("Digite código do produto (Id): ");
            int id = int.Parse(Console.ReadLine());

            var produto = produtoService.GetProduto(id);

            Console.WriteLine($"Produtos: {produto.Id}, {produto.Nome}, {produto.Preco:F2},{produto.Quantidade}");

            Console.WriteLine();

            Console.WriteLine("Quer mesmo excluir esse Produto? (0 - Não / 1 - Sim");
            int opcao = int.Parse(Console.ReadLine());

            if( opcao == 0)
            {
                return;
            }

            produtoService.DeleteProduto(id);

            Console.WriteLine("Produto excluido com sucesso!");
        }

        static int ReadOption(string message)
        {
            Console.Write($"{message}");
            string input = Console.ReadLine();

            int option;
            bool isNumber = int.TryParse(input, out option);

            if( isNumber)
            {
                return option;
            }
            return -1;
        }

    }
}
