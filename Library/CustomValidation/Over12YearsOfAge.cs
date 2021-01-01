using Library.Data;
using System;
using System.ComponentModel.DataAnnotations;
using Library.Models;

namespace Library.CustomValidation
{
    public sealed class Over12YearsOfAge : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var libraryBorrower = (RegisterViewModel)validationContext.ObjectInstance;

            var age = DateTime.Now.Year - libraryBorrower.DateOfBirth.Year;

            return age >= 12
                ? ValidationResult.Success
                : new ValidationResult("you must be at least 18 years old to have an account");
        }
    }
}
