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
        public int EmployeeID { get; set; }

        [Display(Name = "Employee Name")]
        public string EmployeeName { get; set; }
        public string EmployeeAddress { get; set; }

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