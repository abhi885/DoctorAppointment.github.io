using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DoctorWeb.Models
{
    public enum R_Gender
    {
        Male,
        Female
    }
    public class Registration_Form
    {
        [Key]
        [Display(Name ="S.No")]
        public int rid { get; set; }

        [Required(ErrorMessage ="Please Enter Your Firs Name")]
        [Display(Name ="First Name")]
        public string R_FirstName { get; set; }

        [Required(ErrorMessage = "Please Enter Your Last Name")]
        [Display(Name = "Last Name")]
        public string R_LastName { get; set; }

        [Required(ErrorMessage = "Please Select Your Gender")]
        [Display(Name = "Gender")]
        public string R_Gender { get; set; }


        [Display(Name = "Country")]
        public string R_Country { get; set; }

        [Display(Name = "State")]
        public string R_State { get; set; }

        [Display(Name = "City")]
        public string R_City { get; set; }

        [Display(Name = "Phone Number")]
        [Required(ErrorMessage ="Please Enter Your Phone Number")]
        public string R_Contact { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Please Enter Your Email Address")]
        public string R_Email { get; set; }

        //[Display(Name = "Address")]
        //public string R_Address { get; set; }

        //[Display(Name = "Fields")]
        //public string R_Fields { get; set; }

        [Display(Name = "Qualification")]
        public string R_Qualification { get; set; }

        [Display(Name = "Specialization")]
        public string R_Specialization { get; set; }

        [Display(Name = "Work Experience")]
        public string R_WorkExperience { get; set; }

        [Display(Name = "Achievement  Details")]
        public string R_AchievementDetails { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage ="Please Enter Your Password")]
        [DataType(DataType.Password)]
        public string R_Password { get; set; }

        [Display(Name = " Confirm Password")]
        [Required(ErrorMessage = "Please Enter Your Password")]
        [DataType(DataType.Password)]
        [Compare("R_Password")]
        public string R_ConfirmPassword { get; set; }

        //[Display(Name = "Profile States")]
        //public string R_ProfileStates { get; set; }

        [Display(Name = "JoiningDate")]
        [DataType(DataType.Date)]
        public DateTime R_JoiningDate { get; set; }

        //[Display(Name = "Other Details")]
        //public string R_OtherDetails { get; set; }

        //[Display(Name = "Upload Image")]
        //[DataType(DataType.Upload)]
        //[Required]
        //public string R_Image { get; set; }
    }
}
















