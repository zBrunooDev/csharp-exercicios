using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExTaxPayer.Entities
{
    abstract class TaxPayer
    {
        public string Name { get; set; }
        public double IncomeAnnual { get; set; }

        public TaxPayer(string name, double incomeAnnual)
        {
            Name = name;
            IncomeAnnual = incomeAnnual;
        }

        public abstract double TaxCalcultion();

        public override string ToString()
        {
            return $"{Name}: ${TaxCalcultion():F2} ";
        }
       
    }
}
