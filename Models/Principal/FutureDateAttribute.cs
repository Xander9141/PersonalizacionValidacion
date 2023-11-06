using System;
using System.ComponentModel.DataAnnotations;

public class FutureDateAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (value is DateTime dateValue)
        {
            if (dateValue > DateTime.Now)
            {
                return ValidationResult.Success;
            }
        }

        return new ValidationResult("La fecha debe ser en el futuro.");
    }
}
