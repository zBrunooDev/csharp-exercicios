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

        static List<Produto> produtos = new List<Produto>();
        static int contId = 1;

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
        // Listar Produto
        // Buscar por ID
        // Deletar Produto

    }
}
