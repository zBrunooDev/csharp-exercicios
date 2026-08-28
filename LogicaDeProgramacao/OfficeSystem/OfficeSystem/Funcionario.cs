using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeSystem
{
    internal class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public TimeSpan CargaHoraria { get; set; }
        public double Salario { get; set; }
        public string Cargo { get; set; }

    }
}
