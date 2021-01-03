using Library.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace Library.CustomValidation
{
    public sealed class CustomRegistrationValidator : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var registrationModel = (RegisterViewModel)validationContext.ObjectInstance;

            if (string.IsNullOrWhiteSpace(registrationModel.FirstName))
                return new ValidationResult("first name is a required field");

            if (string.IsNullOrWhiteSpace(registrationModel.LastName))
                return new ValidationResult("last name is a required field");

            if (string.IsNullOrWhiteSpace(registrationModel.Password))
                return new ValidationResult("password is a required field");

            if (string.IsNullOrWhiteSpace(registrationModel.ConfirmPassword))
                return new ValidationResult("confirm password is a required field");

            if (registrationModel.ConfirmPassword != registrationModel.Password)
                return new ValidationResult("password and confirm password fields do not match");

            if (DateTime.Now.Year - registrationModel.DateOfBirth.Year <= 12)
                return new ValidationResult("You must be at least 12 years old to own an account");

            return ValidationResult.Success;
        }
    }
}
