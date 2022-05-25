using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace WebApplication4_Form_Validations.Models
{
    public class RegistrationModel
    {
        [Required(ErrorMessage ="FirstName is must")]
        [RegularExpression("^[a-zA-Z]{3,}$",ErrorMessage ="Invaid First Name")]
        [Display(Name ="Enter First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage ="LastName is must")]
        [RegularExpression("^[a-zA-Z]{1,}$", ErrorMessage = "Invaid Last Name")]

        public string LastName { get; set; }


        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set;}


        [Required]
        [RegularExpression("^[\\d]{10}")]
        public string PhoneNo { get; set; }

        [DataType(DataType.Date)]
        [RequiredMin18Years("Minimum age of 18 is required")]
        public DateTime DateOfBirth { get; set; }

        [Range(18,60)]
        public int Age { get; set; }


        [Required]
        public string Password { get; set; }


        [Required]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Passwords do not match")]
        public string ConfirmPassword { get; set; }


    }
}