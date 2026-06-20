using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1047
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;

            string[] vet = Console.ReadLine().Split(' ');

            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);
            c = int.Parse(vet[2]);
            d = int.Parse(vet[3]);

            int totalMinInicio, totalMinFinal, tempoDeJogo, minJogo, horaJogo;

            totalMinInicio = (a * 60) + b;
            totalMinFinal = (c * 60) + d;

            if(totalMinInicio < totalMinFinal)
            {
                tempoDeJogo = totalMinFinal - totalMinInicio;
            }
            else
            {
                tempoDeJogo = 1440 - totalMinInicio + totalMinFinal;
            }

            horaJogo = tempoDeJogo / 60;
            minJogo = tempoDeJogo % 60;

            Console.WriteLine($"O JOGO DUROU {horaJogo} HORA(S) E {minJogo} MINUTO(S)");
        }
    }
}
