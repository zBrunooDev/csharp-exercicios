using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1114
{
    class Program
    {
        static void Main(string[] args)
        {

            int senha = 2002;

            int teste = int.Parse(Console.ReadLine());

            while(teste != senha)
            {

                Console.WriteLine("Senha Invalida");
                teste = int.Parse(Console.ReadLine()); 
                
            }

            Console.WriteLine("Acesso Permitido");
        }
    }
}
