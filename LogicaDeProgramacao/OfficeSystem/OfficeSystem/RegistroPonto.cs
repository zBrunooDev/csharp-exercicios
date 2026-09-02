using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace OfficeSystem
{
    internal class RegistroPonto
    {
        public Funcionario Funcionario {  get; set; }
        public DateTime Entrada { get; set; }
        public DateTime SaidaAlmoco { get; set; }
        public DateTime VoltaAlmoco { get; set; }
        public DateTime Saida { get; set; }

        public RegistroPonto(Funcionario funcionario)
        {
            Funcionario = funcionario;
        }

        public TimeSpan CalcularTempoTrabalhado()
        {
            TimeSpan primeiroPeriodo = SaidaAlmoco - Entrada;
            TimeSpan segundoPeriodo = Saida - VoltaAlmoco;
            return primeiroPeriodo + segundoPeriodo;
        }
        public TimeSpan CalcularTempoAlmoco()
        {
            return VoltaAlmoco - SaidaAlmoco;
        }

        public TimeSpan CalcularBancoHoras()
        {
            return CalcularTempoTrabalhado() - Funcionario.CargaHoraria;
        }
    }
}
