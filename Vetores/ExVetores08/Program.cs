using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ExVetores08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[] altura = new double[n];
            string[] sexo = new string[n];
            string[] s = new string[n];
            int MaiorAltura = 0, MenorAltura = 0;
            double MediaAlturaF, somaAltura = 0, cont = 0;
            int contHomem = 0;

            for (int i = 0; i < n; i++)
            {
                s = Console.ReadLine().Split(' ');
                altura[i] = double.Parse(s[0]);
                sexo[i] = s[1];
            }

            // A maior e menor altra do Grupo
            for (int i = 0;i < n; i++)
            {
                if (altura[i] > altura[MaiorAltura])
                {
                    MaiorAltura = i;
                }
                if (altura[i] < altura[MenorAltura])
                {
                    MenorAltura = i;
                }
            }

            //Media da altura das mulheres

            for(int i = 0; i < n; i++)
            {
                if (sexo[i] == "F")
                {
                    somaAltura += altura[i];
                    cont++;
                }
                else if(sexo[i] == "M")
                {
                    contHomem++;
                }
            }

            MediaAlturaF = somaAltura / cont;

            Console.WriteLine($"Menor altura = {altura[MenorAltura]:F2}");
            Console.WriteLine($"Maior altura = {altura[MaiorAltura]:F2}");
            Console.WriteLine($"Media da altira das mulheres = {MediaAlturaF:F2}");
            Console.WriteLine($"Numero de homens: {contHomem}");

        }
    }
}
