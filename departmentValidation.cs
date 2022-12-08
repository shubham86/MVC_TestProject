using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TestProject_MVC
{
    public class departmentValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                if (value.ToString().Contains("Department"))
                {
                    return ValidationResult.Success;
                }
            }

            return new ValidationResult("Field must conain Department");
        }
    }
}