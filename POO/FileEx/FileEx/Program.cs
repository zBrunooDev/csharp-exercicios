using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Entrada do nome do arquivo.
            Console.Write("Enter file full path: ");
            string sourceFilePath = Console.ReadLine();

            try
            {
                // Vou gravar todas as linhas do arquivo no vetor.
                string[] lines = File.ReadAllLines(sourceFilePath);

                // Instanciando algumas strings
                string sourceFolderPath = Path.GetDirectoryName(sourceFilePath); // Ele pega o caminho do diretório onde o arquivo está. <- caminho da pasta onde está o arquivo
                string targetFolderPath = sourceFilePath + @"\out"; // Pega o caminho do diretório sourceFilePath e unifica com  @"\out"  <- pasta onde quero colocar o resultado
                string targetFilePath = targetFolderPath + @"\summary.csv"; // Aqui eu crio um caminho do arquivo. <- arquivo de resultado

                Directory.CreateDirectory(targetFolderPath); // Eu crio a pasta com o dentor do caminho de targetFolderPath

                using (StreamWriter sw = File.AppendText(targetFilePath)) // Aqui estou abrindo o arquivo no modo escrita - e pedindo para escrever no final do arquivo targetFilePath
                {
                    foreach (string line in lines)  // Percorro o que tinha escrito no arquivo que foi inserido e repassados as informações para o vetor
                    {

                        string[] fields = line.Split(',');  // Aqui eu separo dentro de um vetor fiels cada item que é dividido por uma virgula.
                        string name = fields[0]; // Nome está na posição 0
                        double price = double.Parse(fields[1], CultureInfo.InvariantCulture); // O  preço estpa na  posição 1, já sendo convertido para double
                        int quantity = int.Parse(fields[2]);  // Quantidade sendo pega na  3 posição e já sendo conetida em inteiro
                        // Esses três elementos entram em uma variavel auxiliar.

                        Product prod = new Product(name, price, quantity); // Aqui eu instancio um novo produto com as informações que eu tenho.

                        sw.WriteLine(prod.Name + "," + prod.Total().ToString("F2", CultureInfo.InvariantCulture)); // Aqui eu escrevo no arquivo os dados tratados acima
                    }
                }

            }
            catch (IOException e) // Mensagem de erro caso de algum Exeption.
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
