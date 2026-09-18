using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace ExTaxPayer.Entities
{
    internal class Individual : TaxPayer
    {
        public double HealthSpending { get; set; }

        public Individual(string name, double incomeAnnual, double healthSpending) : base(name, incomeAnnual)
        {
            HealthSpending = healthSpending;
        }

        public override double TaxCalcultion()
        {
            if (IncomeAnnual < 20000.00)
            {
                return (IncomeAnnual * 0.15) - (HealthSpending * 0.05);
            }
            else
            {
                return (IncomeAnnual * 0.25) - (HealthSpending * 0.05);
            }
        }
    }
}
