using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Paycompute.Models.Employee
{
    public class EmployeeEditViewModel : EmployeeViewModel
    {
        [Display(Name = "Photo")]
        public IFormFile ImageUrl { get; set; }
    }
}
