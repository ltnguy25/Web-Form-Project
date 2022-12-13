using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;

namespace WebFormProject.Models
{
    public class Employee
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage ="Enter employee first name")]
        [StringLength(100, MinimumLength = 2)]
        public string FirstName { get; set; }
        [Required(ErrorMessage ="Enter employee last name")]
        [StringLength(100, MinimumLength = 2)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Enter employee date of birth")]
        [Display(Name = "Date of Birth")]
        public DateTime DOB { get; set; }

        [Required(ErrorMessage = "Enter employee email")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone")]
        [RegularExpression(@"^[0-9]{10}$", ErrorMessage = "Enter 10 digit number")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Enter employee start date")]
        public DateTime StartDate { get; set; }

    }
}