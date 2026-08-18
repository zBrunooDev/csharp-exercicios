using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace CadastroDeProdutos.Service
{
    internal class ProdutoService
    {

        private List<Produto> produtos = new List<Produto>();
        private int contId = 0;

        // Cadastrar Produto
        public Produto CriarProduto(string nome, double preco, int quantidade)
        {
            contId += 1;
            return new Produto()
            {
                Id = contId,
                Nome = nome,
                Preco = preco,
                Quantidade = quantidade
            };
        }
        public void RegistrarProduto(string nome, double preco, int quantidade)
        {
            Produto produto = CriarProduto(nome, preco, quantidade);
            SalvarProduto(produto);
        }

        public void SalvarProduto(Produto produto)
        {
            produtos.Add(produto);
        }
        // Listar Produto
        public List<Produto> PegarTodos()
        {
            return produtos;
        }
        // Buscar por ID
        public Produto PegarProduto(int id)
        {
            foreach (Produto produto in produtos)
            {
                if(produto.Id == id) return produto;
            }
            return null;
        }
        // Atualizar produto
        public void AtualizarProduto(Produto produto, string nome, double preco, int quantidade)
        {
            produto.Nome = nome;
            produto.Preco = preco;
            produto.Quantidade = quantidade;
        }
        // Deletar Produto
        public void DeletarProduto(int id)
        {
            var produto = PegarProduto(id);
            if (produto == null) return;
            produtos.Remove(produto);
        }
    }
}
