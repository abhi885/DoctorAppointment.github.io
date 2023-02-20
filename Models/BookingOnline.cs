using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DoctorWeb.Models
{
    public class BookingOnline
    {
        [Key]
        [Display(Name ="Booking id")]
        public int bo_id { get; set; }

       
        [Display(Name = "Name")]
        public string bo_name { get; set; }

        [Display(Name = "Phone")]
        public string bo_phone { get; set; }

        [Display(Name = "Select Date for Appointment")]
        [DataType(DataType.Date)]
        public DateTime bo_date { get; set; }

        [Display(Name = "Select Time for Appointment")]
        [DataType(DataType.Time)]
        public string bo_time { get; set; }

        [Display(Name = "Select Speciality")]
        public string bo_Speciality { get; set; }
    }
}