using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractsPayment.Service
{
    internal class PaypalService : IOnlinePaymentService
    {
        //Regarding my implementation, the professor uses a private constant variable to receive the percentage value.
        private const double FeePercentage = 0.02;
        private const double MonthlyInterest = 0.01;

        public double PaymentFee(double amount)
        {
            return amount * FeePercentage;
        }
        public double Interest(double amount, int months)
        {
            return amount * MonthlyInterest * months;
        }
    }
}
