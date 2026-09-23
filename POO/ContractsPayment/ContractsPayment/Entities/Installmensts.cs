using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractsPayment.Entities
{
    internal class Installmensts
    {
        public DateTime DueDate { get; set; }
        public double Amount { get; set; }

        public Installmensts(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }

    }
}
