namespace PlanningPoker.Shared
{
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class PasswordRequiresNonAlphanumericAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var password = value as string;
            if (password != null && !Regex.IsMatch(password, @"[\W_]+"))
            {
                return new ValidationResult("Passwords must have at least one non alphanumeric character.");
            }
            return ValidationResult.Success;
        }
    }

    public class PasswordRequiresUppercaseAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var password = value as string;
            if (password != null && !password.Any(char.IsUpper))
            {
                return new ValidationResult("Passwords must have at least one uppercase ('A'-'Z').");
            }
            return ValidationResult.Success;
        }
    }

    public class PasswordRequiresLowercaseAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var password = value as string;
            if (password != null && !password.Any(char.IsLower))
            {
                return new ValidationResult("Passwords must have at least one lowercase ('a'-'z').");
            }
            return ValidationResult.Success;
        }
    }
}
