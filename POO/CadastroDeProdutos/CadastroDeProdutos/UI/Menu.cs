using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
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

            produtoService.RegistrarProduto(nome, preco, quantidade);

            Console.WriteLine("Produto cadastrado!");
        }
        // Listagem de produtos
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
                produtoService.ToString(produto);
            }
        }
        //Buscar por ID
        static void BuscarPorId()
        {
            var produto = SelecionarPorId();
            if (produto == null )return;
            produtoService.ToString(produto);

        }
        //Atualizar dados de algum produto
        static void AtualizarProduto()
        {
            
        }
        //Deletar produto
        static void Delete()
        {
            Console.Write("Digite código do produto (Id): ");
            int id = int.Parse(Console.ReadLine());

            var produto = produtoService.GetProduto(id);

            produtoService.ToString(produto);

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
        //Método auxiliar para pegar por ID:
        static Produto SelecionarPorId()
        {
            int id = ReadOption("Digite o ID: ");
            if(id == -1)
            {
                Console.WriteLine("Opção invalida!");
                return null;
            }
            var produto = produtoService.GetProduto(id);
            if (produto == null)
            {
                Console.WriteLine("Id não encontrado!");
            }
                return produto;
        }

    }
}
