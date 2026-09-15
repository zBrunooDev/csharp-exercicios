using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using CadastroDeProdutos.Model.Enum;
using Microsoft.SqlServer.Server;

namespace CadastroDeProdutos.Service
{
    internal class ProdutoService
    {

        private List<Produto> produtos = new List<Produto>();
        private int contId = 0;

        // Cadastrar Produto
        public Produto CriarProduto(string nome, string descricao, double preco, int quantidade, Categoria categoria)
        {
            contId += 1;
            return new Produto()
            {
                Id = contId,
                Nome = nome,
                Descricao = descricao,
                Preco = preco,
                Quantidade = quantidade,
                Categoria = categoria,
                DataCadastro = DateTime.Now,
            };
        }
        public void RegistrarProduto(string nome, string descricao, double preco, int quantidade, Categoria categoria)
        {
            Produto produto = CriarProduto(nome, descricao, preco, quantidade, categoria);
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
        public void AtualizarProduto(Produto produto, string nome, string descricao, double preco, int quantidade, Categoria categoria)
        {
            produto.Nome = nome;
            produto.Descricao = descricao;
            produto.Preco = preco;
            produto.Quantidade = quantidade;
            produto.Categoria = categoria;
            produto.DataCadastro = DateTime.Now;
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
