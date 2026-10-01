using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractsPayment.Entities
{
    public class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        public List<Installment> Installmensts { get; set; }

        public Contract(int number, DateTime date, double totalvalue)
        {
            Number = number;
            Date = date;
            TotalValue = totalvalue;
        }
        // Add installments to the list
        public void AddInstallments(Installment installmensts)
        {
            Installmensts.Add(installmensts);
        }
        // Remove installments from the list
        public void RemoveInstallments(Installment installmensts)
        {
            Installmensts.Remove(installmensts);
        }

    }
}
