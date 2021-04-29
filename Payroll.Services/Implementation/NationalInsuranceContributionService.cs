using System;
using System.Collections.Generic;
using System.Text;

namespace Payroll.Services.Implementation
{
    public class NationalInsuranceContributionService : INationalInsuranceContributionService
    {        
        public decimal NIContribution(decimal totalAmount)
        {
            decimal NIRate = .0m;
            decimal NIC;
            if (totalAmount < 719)
            {
                //Lower Earning Limit Rate & below Primary Threshold
                NIC = 0m;
            }
            else if (totalAmount >= 719 && totalAmount <= 4167)
            {
                //Between Primary Threshold and Upper Earnings Limit (UEL)
                NIRate = .12m;
                NIC = ((totalAmount - 719) * NIRate);
            }
            else
            {
                //Above Upper Earnings Limit (UEL)
                NIRate = .02m;
                NIC = ((4167 - 719) * .12m) + ((totalAmount - 4167) * NIRate);
            }
            return NIC;
        }
    }
}
