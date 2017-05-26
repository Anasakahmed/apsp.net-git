using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcApplication23.Models
{
    public class students
    {
        
        [Display(Name = "Applicant ID:")]

        public int stu_id { get; set; }

        [Required(ErrorMessage = "CNIC is Required!")]
        [Display(Name = "CNIC:")]

        public string stu_cnic { get; set; }


        [Required(ErrorMessage = "Name is Required!")]
        [Display(Name = "NAME:")]

        public string stu_name { get; set; }

        [Required(ErrorMessage = "Father Name is Required!")]
        [Display(Name = "Father Name:")]
         public string stu_fname { get; set; }

     
        
        [Required(ErrorMessage = "Address is Required!")]
        [Display(Name = "Address:")]
        public string stu_address { get; set; }

        [Required(ErrorMessage = "Date Of Birth is Required!")]
        [Display(Name = "Date Of Birth:")]

        public string stu_dob { get; set; }

        [Required(ErrorMessage = "Nationality is Required!")]
        [Display(Name = "Nationality:")]

        public string nationality { get; set; }

        [Required(ErrorMessage = "Domicile is Required!")]
        [Display(Name = "Domicile:")]
        public string stu_domicile { get; set; }

        [Required(ErrorMessage = "City is Required!")]
        [Display(Name = "City:")]

        public string stu_city { get; set; }

  

    }
}