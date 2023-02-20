using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DoctorWeb.Models
{
    [Table("PatientQueries")]
    public class Query
    {
        [Key]
        [Display(Name ="Querry Id")]
        public int Qid { get; set; }

        [Required]
        [Display(Name ="Your Name")]
        public string Qname { get; set; }

        [Required]
        [Display(Name = "Your Email")]
        [DataType(DataType.EmailAddress)]
        public string QEmail { get; set; }


        [Required]
        [Display(Name = "Your Contact")]
        public string Qcontact { get; set; }


        [Required]
        [Display(Name = "Your Question")]
        public string Qquestion { get; set; }

        [ScaffoldColumn(false)]
        public int Drid { get; set; }
    }
}