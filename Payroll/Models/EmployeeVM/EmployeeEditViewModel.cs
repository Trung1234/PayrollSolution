using Microsoft.AspNetCore.Http;
using Payroll.Ultility;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Payroll.Models.EmployeeVM
{
    public class EmployeeEditViewModel : EmployeeViewModel
    {
        [Display(Name = "Photo")]
        [Required(ErrorMessage = "Pick an Image")]
        [AllowedExtensions(new string[] { ".jpg", ".jpeg", ".png" })]
        public IFormFile ImageUrl { get; set; }
    }
}
