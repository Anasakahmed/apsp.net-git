using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; //i  have added this class for validation..................
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


        // ssc records...........................................................................................



        [Required(ErrorMessage = "CNIC is Required!")]
        [Display(Name = "CNIC:")]

       // public int  ssc_id{ get; set; }

       

        public string ssc_institute { get; set; }

        

        public string ssc_board { get; set; }
       
        
        public int ssc_totalmarks { get; set; }



      

        public string ssc_enrolment { get; set; }


        public int ssc_fk_studentreg { get; set; }


        //hsc..................................................................................

        [Required(ErrorMessage = "CNIC is Required!")]
        [Display(Name = "CNIC:")]

        // public int  hsc_id{ get; set; }


        public string hsc_institute { get; set; }

        [Required(ErrorMessage = "Board Of Education is Required!")]
        [Display(Name = "Board Of Education :")]

        public string hsc_board { get; set; }

        [Required(ErrorMessage = "TotalMarks is Required!")]
        [Display(Name = "TotalMarks :")]

        public int hsc_totalmarks { get; set; }



        [Required(ErrorMessage = "Enrolment# is Required!")]
        [Display(Name = "Enrolment# :")]

        public string hsc_enrolment { get; set; }


        public int hsc_fk_studentreg { get; set; }



    }
}