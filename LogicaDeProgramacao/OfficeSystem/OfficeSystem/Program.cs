using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //entrada de dados

            Console.WriteLine("Sitema  de marcação de tempo");

            Console.Write("Entrada: ");
            DateTime entrada = DateTime.Parse(Console.ReadLine());

            Console.Write("Saída para almoço: ");
            DateTime saidaAlmoco = DateTime.Parse(Console.ReadLine());

            Console.Write("Volta do almoço: ");
            DateTime voltaAlmoco = DateTime.Parse(Console.ReadLine());

            Console.Write("Saída: ");
            DateTime saida = DateTime.Parse(Console.ReadLine());

            //calculo dos 2 periodos

            TimeSpan periodoManha = saidaAlmoco - entrada;

            TimeSpan horarioAlmoco = voltaAlmoco - saidaAlmoco;

            TimeSpan periodoTarde = saida - voltaAlmoco;

            TimeSpan totalTrabalhado = periodoManha + periodoTarde;

            TimeSpan cargaHoraria = new TimeSpan(08, 48, 00);

            TimeSpan saldo = totalTrabalhado - cargaHoraria;

            //Saida

            Console.WriteLine($"Carga esperada: {cargaHoraria:hh\\:mm}");
            Console.WriteLine($"Trabalhado: {totalTrabalhado:hh\\:mm}");
            Console.WriteLine($"Saldo: {saldo}");
        }

    }
}
