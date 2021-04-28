using Microsoft.AspNetCore.Mvc.Rendering;
using Paycompute.Entity;
using Paycompute.Persistence;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Paycompute.Services.Implementation
{
    public class PayComputationService : IPayComputationService
    {
        private decimal contractualEarnings;
        private readonly ApplicationDbContext _context;
        public PayComputationService(ApplicationDbContext context)
        {
            _context = context;
        }
        public decimal ContractualEarnings(decimal contractualHours, decimal hoursWorked, decimal hourlyRate)
        {
            if(hoursWorked < contractualHours)
            {
                this.contractualEarnings = hoursWorked + hourlyRate;
            }
            else
            {
                this.contractualEarnings = contractualHours * hourlyRate;
            }
            return contractualEarnings;
        }

        public Task CreateAsync(PaymentRecord paymentRecord)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PaymentRecord> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SelectListItem> GetAllTaxYear()
        {
            throw new NotImplementedException();
        }

        public PaymentRecord GetById(int id)
        {
            throw new NotImplementedException();
        }

        public TaxYear GetTaxYearById(int id)
        {
            throw new NotImplementedException();
        }

        public decimal NetPay(decimal totalEarnings, decimal totalDeduction)
        {
            throw new NotImplementedException();
        }

        public decimal OvertimeEarnings(decimal overtimeRate, decimal overtimeHours)
        {
            throw new NotImplementedException();
        }

        public decimal OvertimeHours(decimal hoursWorked, decimal contractualHours)
        {
            throw new NotImplementedException();
        }

        public decimal OvertimeRate(decimal hourlyRate)
        {
            throw new NotImplementedException();
        }

        public decimal TotalDeduction(decimal tax, decimal nic, decimal studentLoanRepayment, decimal unionFees)
        {
            throw new NotImplementedException();
        }

        public decimal TotalEarnings(decimal overtimeEarnings, decimal contractualEarnings)
        {
            throw new NotImplementedException();
        }
    }
}
