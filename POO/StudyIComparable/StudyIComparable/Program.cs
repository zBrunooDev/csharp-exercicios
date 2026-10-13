using System;
using System.Collections.Generic;
using System.IO;

namespace StudyIComparable
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            string path = @"C:\Users\zbrun\OneDrive\Documentos\ExIComparable.txt"; // Caminho do meu arquivo.
            try
            {
                // abre o arquivo para leitura e garante que o leitor seja descartado ao sair do bloco, inclusive se ocorrer uma exceção.
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream) // continua enquanto ainda houver conteúdo para ler no arquivo.
                    {
                        list.Add(new Employee(sr.ReadLine())); // Cria um novo funcionario recebendo como argumeto a linha escrita;
                    }
                    list.Sort(); // Ordena a lista conforme o critério definido por Employee.CompareTo, neste caso, pelo nome.
                    foreach (Employee emp in list)
                    {
                        Console.WriteLine(emp); // Printa na tela a lista ordenada.
                    }
                }
            }
            // Caso aconteça algum erro.
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
