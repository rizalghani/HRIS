using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HRIS.Models
{
    public class Employee
    {
        public int EmpID { get; set; }

        [Required(ErrorMessage = "{0} is required !")]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "{0} is required !")]
        [Display(Name = "Email")]
        [StringLength(256, ErrorMessage = "{0} maximal {1} characters !")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$", ErrorMessage = "{0} is not valid !")]
        public string Email { get; set; }

        [Required(ErrorMessage = "{0} is required !")]
        [Display(Name = "Departement")]
        public string Departement { get; set; }
    }
}
