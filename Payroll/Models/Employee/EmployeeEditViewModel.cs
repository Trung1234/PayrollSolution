using Microsoft.AspNetCore.Http;
using Paycompute.Ultility;
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
        [Required(ErrorMessage = "Pick an Image")]
        [AllowedExtensions(new string[] { ".jpg", ".jpeg", ".png" })]
        public IFormFile ImageUrl { get; set; }
    }
}
