using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TestProject_MVC.Models
{
    public class Department
    {
        [Required]
        public int DepartmentID { get; set; }

        [departmentValidation]
        public string DepartmentName { get; set; }
    }
}