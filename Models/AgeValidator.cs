#pragma warning disable CS8605
using System.ComponentModel.DataAnnotations;

namespace FormSubmission.Models;

public class AgeValidator : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        int newAge = (int)value;

        if (newAge > 0)
        {
            return ValidationResult.Success;
        }
        else
        {
            return new ValidationResult("La edad no puede ser negativa");
        }
    }
}