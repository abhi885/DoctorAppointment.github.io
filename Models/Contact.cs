using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DoctorWeb.Models
{
    [Table("Contact Form")]
    public class Contact
    {
        [Key]
        [Display(Name ="Contact id")]
        public int C_id { get; set; }

        [Required]
        [Display(Name ="Fist Name")]
        [StringLength(20,MinimumLength =3)]
        public string C_FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [StringLength(20, MinimumLength = 3)]
        public string C_LasttName { get; set; }

        [Required]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string C_Email { get; set; }

        [Required]
        [Display(Name = "Subjec")]
        public string C_Subject { get; set; }

        [Required]
        [Display(Name = "Message")]
        public string C_Message { get; set; }

    }
}