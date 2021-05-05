using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Payroll.Models.EmployeeVM
{
    public class EmployeeDisplayViewModel : EmployeeViewModel
    {
        public string FullName { get; set; }
        public string ImageUrl { get; set; }
    }
}
