using System;
using Interfaces2.Entities;


namespace Interfaces2.Service
{
    internal class ContractService
    {
        private IOnlinePaymentService _iOnlinePaymentService;

        public ContractService(IOnlinePaymentService iOnlinePaymentService)
        {
            _iOnlinePaymentService = iOnlinePaymentService;
        }
        public void ProcessContract(Contract contract, int months)
        {
            Installment installment;
            double baseAmount = contract.TotalValue / months;
            for (int i = 1; i <= months; i++)
            {
                DateTime dueDate = contract.Date.AddMonths(i);
                double updatedQuota = baseAmount + _iOnlinePaymentService.Interest(baseAmount, i);
                double fullQuota = updatedQuota + _iOnlinePaymentService.PaymentFee(baseAmount);
                installment = new Installment(dueDate, fullQuota);
                contract.AddInstallment(installment);
            }
            
                
            }
        }
    }
}
