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
    }
}
