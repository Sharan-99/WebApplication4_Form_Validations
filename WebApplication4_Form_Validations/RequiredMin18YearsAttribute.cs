using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace WebApplication4_Form_Validations
{
    public class RequiredMin18YearsAttribute : ValidationAttribute
    {
        private readonly string message;
        public RequiredMin18YearsAttribute(string message)
        {
            this.message = message;
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime DOB = Convert.ToDateTime(value);
            if (DateTime.Now.Year - DOB.Year < 18)
                return new ValidationResult(message);
            else
                return ValidationResult.Success;
        }
    }
}