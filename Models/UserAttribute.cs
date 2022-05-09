using System.ComponentModel.DataAnnotations;
using System;

namespace Years.Models
{
    public class UserAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(
            object? value, ValidationContext validationContext)
        {

            if (value != null)
            {
                int year = (int)value;

                DateTime.IsLeapYear(year);

                if (DateTime.IsLeapYear(year))
                    return new ValidationResult("Rok przestępny");
                else
                    return new ValidationResult("Rok nie przestępny");
            }

            return ValidationResult.Success;
        }
    }
}
