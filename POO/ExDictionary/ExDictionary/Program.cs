using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();

            //Console.Write("Enter file full path: ");
            string path = @"C:\Users\zbrun\OneDrive\Documentos\ExeciceFiles\votation.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string candidates = line[0];
                        int votes = int.Parse(line[1]);

                        if (dic.ContainsKey(candidates))
                        {
                            dic[candidates] += votes;
                        }
                        else
                        {
                            dic[candidates] = votes;
                        }
                    }
                    foreach(var item in dic)
                    {
                        Console.WriteLine($"{item.Key}: {item.Value}");
                    }
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }


        }
    }
}
