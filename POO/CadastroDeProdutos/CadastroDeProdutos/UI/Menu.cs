using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using CadastroDeProdutos.Model.Enum;
using CadastroDeProdutos.Service;

namespace CadastroDeProdutos.UI
{
    public class Menu
    {
        static ProdutoService produtoService = new ProdutoService();

        public void Comecar()
        {
            bool running = true;
            while (running)
            {
                Tela();
                int opcao = LerEntrada("");
                if (opcao == -1)
                {
                    Console.WriteLine("opção invalida!");
                    continue;
                }
                
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
                    case 4:
                        AtualizarProduto();
                        break;
                    case 5:
                        DeletarProduto();
                        break;
                    case 0:
                        Console.WriteLine("Encerrando programa!");
                        running = false;
                        break;
                }
                
            }
        }
        static void Tela()
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
            string nome = LerNome("Digite o nome do Produto: ");
            double preco = LerDouble("Digite o preço do Produto: R$ ");
            int quantidade = LerEntrada("Digite a quantidade do Produto: ");

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
                EscreverProduto(produto);
            }
        }
        //Buscar por ID
        static void BuscarPorId()
        {
            var produto = SelecionarPorId();
            if (produto == null )return;
            EscreverProduto(produto);

        }
        //Atualizar dados de algum produto
        static void AtualizarProduto()
        {
            var produto = SelecionarPorId();
            if (produto == null )return;

            EscreverProduto(produto);

            Console.WriteLine();

            string nome = LerNome("Digite o nome do Produto: ");
            double preco = LerDouble("Digite o preço do Produto: R$ ");
            int quantidade = LerEntrada("Digite a quantidade do Produto: ");

            produtoService.AtualizarProduto(produto, nome, preco, quantidade);
        }
        //Deletar produto
        static void DeletarProduto()
        {
            var produto = SelecionarPorId();
            if (produto == null) return;

            EscreverProduto(produto);

            Console.WriteLine();

            Console.WriteLine("Quer mesmo excluir esse Produto? (0 - Não / 1 - Sim");
            int opcao = int.Parse(Console.ReadLine());

            if( opcao == 0)
            {
                return;
            }

            produtoService.DeletarProduto(produto.Id);

            Console.WriteLine("Produto excluido com sucesso!");
        }
        // Ler entrada para tipo inteiro
        static int LerEntrada(string message)
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
        //Ler entrada para tipo Double
        static double LerDouble(string mensagem)
        {
            Console.Write($"{mensagem}");
            string input = Console.ReadLine();

            double valorDouble;
            bool isNumber = Double.TryParse(input, out valorDouble);

            if (isNumber)
            {
                return valorDouble;
            }
            return -1;
        }

        //Campo para ler o Nome

        static string LerNome(string mensagem)
        {
            // preciso arrumar
            string nome;
            do
            {
                Console.Write($"{mensagem}");
                nome = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(nome));

            return nome;
        }

        Categoria LerEnum(string mensagem)
        {
            Console.Write($"{mensagem}");
            bool conseguiuConverter;
            do
            {
                string categoria = LerNome("Digite o nome da categoria: ");
                Categoria categoriaConvertida;

                conseguiuConverter = Enum.TryParse<Categoria>(categoria, out categoriaConvertida);
            } while (!conseguiuConverter);

            // Preciso fializar a logica

            return categoriaConve;
        }

        //Método auxiliar para pegar por ID:
        static Produto SelecionarPorId()
        {
            int id = LerEntrada("Digite o ID: ");
            if(id == -1)
            {
                Console.WriteLine("Opção invalida!");
                return null;
            }
            var produto = produtoService.PegarProduto(id);
            if (produto == null)
            {
                Console.WriteLine("Id não encontrado!");
                return null;
            }
                return produto;
        }

        static void EscreverProduto(Produto produto)
        {
            Console.WriteLine($"ID: {produto.Id}, Nome: {produto.Nome}, Preço: {produto.Preco:F2}, Quantidade: {produto.Quantidade}");
        }

    }
}
