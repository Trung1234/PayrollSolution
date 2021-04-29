using System;
using System.Collections.Generic;
using System.Text;

namespace Payroll.Services
{
    public interface INationalInsuranceContributionService
    {
        decimal NIContribution(decimal totalAmount);
    }
}
