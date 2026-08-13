using System;
using System.Collections.Generic;
using System.Linq;
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
            Display();
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

            int opcao = int.Parse(Console.ReadLine());

            do
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

            } while (opcao != 0);
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
            Console.Write("Digite código do produto (Id): ");
            int procurarId = int.Parse(Console.ReadLine());

            foreach (Produto produto in produtos)
            {
                if (produto.Id == procurarId)
                {
                    Console.WriteLine($"Id: {produto.Id}, Nome: {produto.Nome}, R$ {produto.Preco}, Quantidade: {produto.Quantidade}");
                }
            }

        }

        public static void Delete()
        {
            Console.Write("Digite código do produto (Id): ");
            int id = int.Parse(Console.ReadLine());

            foreach (Produto produto in produtos)
            {
                if (produto.Id == id)
                {
                    produtos.Remove(produto);
                }
                else return;
            }

        }

    }
}
