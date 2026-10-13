using System;
using System.Globalization;

namespace StudyIComparable
{
    internal class Employee : IComparable
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        // Construtor recebe uma linha do arquivo CSV, separa seus dados pela vírgula e atribui o nome e o salário às propriedades do funcionário.
        public Employee(string csvEmployee) 
        {
            string[] vect = csvEmployee.Split(',');
            Name = vect[0];
            Salary = double.Parse(vect[1], CultureInfo.InvariantCulture);
        }
        public override string ToString()
        {
            return Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

        // Operação de comparação para que o método Sort funcione com a lista de objetos.
        public int CompareTo(object obj)
        {
            if (!(obj is Employee)) // Verifica se o objeto de comparação é um Employee
            {
                throw new ArgumentException("Comparing error: argument is not an Employee");
            }
            Employee other = obj as Employee; // Tenta converter uma referência para outro tipo, retornando null quando a conversão não é possível
            return Name.CompareTo(other.Name); // Retorna um inteiro que indica o resultado da comparação.
        }
    }
}
