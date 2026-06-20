using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1046
{
    class Program
    {
        static void Main(string[] args)
        {
            int horaInicio, horaFinal, tempoDoJogo;

            string[] vet = Console.ReadLine().Split(' ');

            horaInicio = int.Parse(vet[0]);
            horaFinal = int.Parse(vet[1]);

            if (horaInicio < horaFinal)
                tempoDoJogo = horaFinal - horaInicio;
            else
                tempoDoJogo = 24 - horaInicio + horaFinal;

            Console.WriteLine($"O JOGO DUROU {tempoDoJogo} HORA(S)");

        }
    }
}
