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

        public void ProcessContract(Contract contract, int months)
        {

            double valuePerIntallments = contract.TotalValue / months;
            
            for(int i = 0; i < months; i++)
            {
                // I needed to finish the program logic
            }

        }

    }
}
