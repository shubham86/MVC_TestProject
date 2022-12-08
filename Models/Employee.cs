using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace TestProject_MVC.Models
{
    public class Employee
    {
        [Display(Name = "Employee Number")]
        [Required(ErrorMessage ="Please enter Employee Number")]
        [Range(1, 9999, ErrorMessage = "Value should between 1 to 9999")]
        public int EmployeeID { get; set; }

        [Display(Name = "Employee Name")]
        [Required(ErrorMessage = "Please enter Employee Name")]
        public string EmployeeName { get; set; }

        [Display(Name ="Address")]
        public string EmployeeAddress { get; set; }

        [Display(Name = "Email ID")]
        [Required(ErrorMessage = "Please enter Email ID")]
        public string EmployeeEmail { get; set; }


        [Display(Name = "Mobile")]
        [Required(ErrorMessage = "Please enter mobile number")]
        [MaxLength(10,ErrorMessage ="Please enter valid mobile number")]
        [MinLength(10, ErrorMessage = "Please enter valid mobile number")]
        public string EmployeeMobile { get; set; }


        [Required(ErrorMessage = "Please enter date of birth")]
        [Range(typeof(DateTime),"1/1/1922","1/1/2004",ErrorMessage ="Date range from 1-1-1922 to 1-1-2004")]
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }
        public bool isActive { get; set; }


        [Display(Name = "Entry Time")]
        [DataType(DataType.Time)]
        public DateTime EntryTime { get; set; }

        public Department Department { get; set; }
    }
}