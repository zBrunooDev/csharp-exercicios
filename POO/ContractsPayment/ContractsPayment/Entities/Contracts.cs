using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractsPayment.Entities
{
    internal class Contracts
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        public List<Installmensts> Installmensts { get; set; }

        public Contracts(int number, DateTime date, double totalvalue)
        {
            Number = number;
            Date = date;
            TotalValue = totalvalue;
        }


    }
}
