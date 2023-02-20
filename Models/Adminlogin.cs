using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DoctorWeb.Models
{
    [Table("Admin Registration")]
    public class Adminlogin
    {
        [Key]
        [Display(Name ="Admin Id")]
        public int AdminId { get; set; }

        [Required]
        [Display(Name ="First Name")]
        public string AdminFirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string AdminLastName { get; set; }

        [Required]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string AdminEmail { get; set; }


        [Required]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string AdminPassword { get; set; }

        [Required]
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("AdminPassword")]
        public string AdminConfirmPassword { get; set; }
    }
}