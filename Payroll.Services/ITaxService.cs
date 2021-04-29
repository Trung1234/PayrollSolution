using System;
using System.Collections.Generic;
using System.Text;

namespace Payroll.Services
{
    public interface ITaxService
    {
        decimal TaxAmount(decimal totalAmount);
    }
}
