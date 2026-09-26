using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using CadastroDeProdutos.Model.Enum;

namespace CadastroDeProdutos
{
    internal class Produto
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Preco {  get; set; }
        public int Quantidade { get; set; }
        public DateTime DataCadastro { get; set; }
        public StatusProduto Status {  get; set; }
        public Categoria Categoria { get; set; }

        public Produto() { }

        public Produto(string nome, string descricao, double preco, int quantidade, DateTime dataCadastro, Categoria categoria)
        {
            Nome = nome;
            Descricao = descricao;
            Preco = preco;
            Quantidade = quantidade;
            DataCadastro = dataCadastro;
            //Status = status;
            Categoria = categoria;
        }

        public override string ToString()
        {
            Console.WriteLine();
            return $"ID: {Id},\nNome: {Nome},\nDescrição: {Descricao},\nPreço: {Preco:F2},\nQuantidade: {Quantidade},\nData de cadastro: {DataCadastro.ToString("dd/MM/yyyy - HH:mm")}";
            Console.WriteLine();
        }

    }
}
