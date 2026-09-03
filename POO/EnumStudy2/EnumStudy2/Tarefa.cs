using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumStudy2
{
    internal class Tarefa
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public PrioridadeEnum Prioridade { get; set; }

    }
}
