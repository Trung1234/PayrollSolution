using Payroll.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Payroll.Models.Payment
{
    public class PaymentRecordIndexViewModel : PaymentRecordViewModel
    {
        public string Year { get; set; }
        [Display(Name = "Month")]
        public string PayMonth { get; set; }
        [Display(Name = "Pay Date")]
        public DateTime PayDate { get; set; }
    }
}
