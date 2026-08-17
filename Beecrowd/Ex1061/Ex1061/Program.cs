using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1061
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Leitura do dia inicial
            string[] entradaDiaInicio = Console.ReadLine().Split(' ');
            int diaInicio = int.Parse(entradaDiaInicio[1]);

            // Leitura da hora, minuto e segundo iniciais (formato: hh : mm : ss)
            string[] entradaHoraInicio = Console.ReadLine().Split(':');
            int horaInicio = int.Parse(entradaHoraInicio[0].Trim());
            int minutoInicio = int.Parse(entradaHoraInicio[1].Trim());
            int segundoInicio = int.Parse(entradaHoraInicio[2].Trim());

            // Leitura do dia final
            string[] entradaDiaFim = Console.ReadLine().Split(' ');
            int diaFim = int.Parse(entradaDiaFim[1]);

            // Leitura da hora, minuto e segundo finais (formato: hh : mm : ss)
            string[] entradaHoraFim = Console.ReadLine().Split(':');
            int horaFim = int.Parse(entradaHoraFim[0].Trim());
            int minutoFim = int.Parse(entradaHoraFim[1].Trim());
            int segundoFim = int.Parse(entradaHoraFim[2].Trim());

            // Converte tudo para segundos desde o início
            int inicioEmSegundos = segundoInicio + (minutoInicio * 60) + (horaInicio * 3600) + (diaInicio * 86400);
            int fimEmSegundos = segundoFim + (minutoFim * 60) + (horaFim * 3600) + (diaFim * 86400);

            // Diferença total em segundos
            int duracaoTotal = fimEmSegundos - inicioEmSegundos;

            // Converte o total de segundos de volta para Dias, Horas, Minutos e Segundos
            int W = duracaoTotal / 86400;
            int resto = duracaoTotal % 86400;

            int X = resto / 3600;
            resto %= 3600;

            int Y = resto / 60;
            int Z = resto % 60;

            // Impressão da saída conforme especificado
            Console.WriteLine($"{W} dia(s)");
            Console.WriteLine($"{X} hora(s)");
            Console.WriteLine($"{Y} minuto(s)");
            Console.WriteLine($"{Z} segundo(s)");
        }
    }
}
