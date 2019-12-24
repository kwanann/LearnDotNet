using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVC_Week2.Models
{
    public partial class EmployeeMetadata
    {
        [Required(ErrorMessage = "Employee FirstName is required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Name Should be minimum 3 characters and a maximum of 100 characters")]
        [DataType(DataType.Text)]
        [Display(Name ="First name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Employee Last Name is required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Last Name should be a minimum of 2 characters")]
        [DataType(DataType.Text)]
        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Employee Login Password is required")]
        [StringLength(100, MinimumLength = 12, ErrorMessage = "Password should be minimum 12 characters and a maximum of 100 characters")]
        [DataType(DataType.Password)]
        [Display(Name = "Login Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Employee Phone Contact is required")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Phone contact should have minimum 6 characters")]
        [Phone]
        [Display(Name = "Phone")]
        public string Phone { get; set; }
    }
    
    [MetadataType(typeof(EmployeeMetadata))]
    public partial class Employee
    { }
}