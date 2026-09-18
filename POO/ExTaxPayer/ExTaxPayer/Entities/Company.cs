using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExTaxPayer.Entities
{
    internal class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company(string name, double incomeAnnual, int numberOfEmployees) : base(name, incomeAnnual)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double TaxCalcultion()
        {
            if (NumberOfEmployees > 10)
            {
                return IncomeAnnual * 0.14;
            }
            else
            {
                return IncomeAnnual * 0.16;
            }
        }
    }
}
