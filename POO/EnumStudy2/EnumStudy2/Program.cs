using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumStudy2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Tarefa tarefa = new Tarefa
            {
                Id = 1342,
                Descricao = "Arrumar impressora",
                Prioridade = PrioridadeEnum.Urgente
            };

            Console.WriteLine(tarefa);

            Console.WriteLine(); 

            switch (tarefa.Prioridade)
            {
                case PrioridadeEnum.Baixa:
                    Console.WriteLine("Essa tarefa pode aguardar");
                    break;
                case PrioridadeEnum.Media:
                    Console.WriteLine("Esta tarefa deve ser realizada em breve.");
                    break;
                case PrioridadeEnum.Alta:
                    Console.WriteLine("Esta tarefa precisa de atenção.");
                    break;
                case PrioridadeEnum.Urgente:
                    Console.WriteLine("Esta tarefa precisa ser resolvida imediatamente!");
                    break;
            }

        }
    }
}
