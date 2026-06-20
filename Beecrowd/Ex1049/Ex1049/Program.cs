using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1049
{
    class Program
    {
        static void Main(string[] args)
        {

            string tipo, animalia, alimentar;

            tipo = Console.ReadLine();
            animalia = Console.ReadLine();
            alimentar = Console.ReadLine();

            if(tipo == "vertebrado")
            {
                if(animalia == "ave")
                {
                    if(alimentar == "carnivoro")
                    {
                        Console.WriteLine("aguia");
                    }
                    else if(alimentar == "onivoro")
                    {
                        Console.WriteLine("pomba");
                    }
                }
                else if(animalia == "mamifero")
                {
                    if (alimentar == "onivoro")
                    {
                        Console.WriteLine("homem");
                    }
                    else if (alimentar == "herbivoro")
                    {
                        Console.WriteLine("vaca");
                    }
                }
            }
            else if(tipo == "invertebrado")
            {
                if(animalia == "inseto")
                {
                    if(alimentar == "hematofago")
                    {
                        Console.WriteLine("pulga");
                    }
                    else if(alimentar == "herbivoro")
                    {
                        Console.WriteLine("lagarta");
                    }
                }
                else if(animalia == "anelideo")
                {
                    if(alimentar == "hematofago")
                    {
                        Console.WriteLine("sanguessuga");
                    }
                    else if(alimentar == "onivoro")
                    {
                        Console.WriteLine("minhoca");
                    }
                }
            }
        }
    }
}
