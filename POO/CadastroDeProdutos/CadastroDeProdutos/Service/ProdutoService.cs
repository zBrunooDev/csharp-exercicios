using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeProdutos.Service
{
    internal class ProdutoService
    {

        private List<Produto> produtos = new List<Produto>();
        static int contId = 0;

        // Cadastrar Produto
        public Produto CadastrarProduto(string nome, double preco, int quantidade)
        {
            contId += 1;
            return new Produto()
            {
                Nome = nome,
                Preco = preco,
                Quantidade = quantidade
            };     
        }
        public void SalvarCadastro(Produto produto)
        {
            produtos.Add(produto);
        }
        // Listar Produto
        public List<Produto> PegarTodos()
        {
            return produtos;
        }
        // Buscar por ID
        // Deletar Produto

    }
}
