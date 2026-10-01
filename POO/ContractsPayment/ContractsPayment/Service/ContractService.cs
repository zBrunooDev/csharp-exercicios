using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContractsPayment.Entities;

namespace ContractsPayment.Service
{
    internal class ContractService
    {

        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {

            double valuePerIntallments = contract.TotalValue / months;

            for (int i = 1; i <= months; i++)
            {
                // Processing the payment date
                DateTime dueDate = contract.Date.AddMonths(i);

                // Processing the tax payment
                double amount = valuePerIntallments + _onlinePaymentService.Interest(valuePerIntallments, i);
                amount += _onlinePaymentService.PaymentFee(amount);

                // Create an installment with correct information
                Installment installment = new Installment(dueDate, amount);


                // Adding an installment to the installments list
                contract.AddInstallments(installment);

            }

        }

    }
}
