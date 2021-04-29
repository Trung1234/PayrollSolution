using System;
using System.Collections.Generic;
using System.Text;

namespace Payroll.Services.Implementation
{
    public class TaxService : ITaxService
    {        
        public decimal TaxAmount(decimal totalAmount)
        {
            decimal taxRate = .0m;
            decimal tax = 0;
            if (totalAmount <= 1042)
            {
                //Tax Free Rate
                tax = totalAmount * taxRate;
            }
            else if (totalAmount > 1042 && totalAmount <= 3125)
            {
                //Basic tax rate
                taxRate = .20m;
                //Income tax
                tax = (1042 * .0m) + ((totalAmount - 1042) * taxRate);
            }
            else if (totalAmount > 3125 && totalAmount <= 12500)
            {
                //Higher tax rate
                taxRate = .40m;
                //Income tax
                tax = (1042 * .0m) + ((3125 - 1042) * .20m) + ((totalAmount - 3125) * taxRate);
            }
            else 
            {
                //Additional tax Rate
                taxRate = .45m;
                //Income tax
                tax = (1042 * .0m) + ((3125 - 1042) * .20m) +
                    ((12500 - 3125) * .40m) + ((totalAmount - 12500) * taxRate);
            }
            return tax;
        }
    }
}
