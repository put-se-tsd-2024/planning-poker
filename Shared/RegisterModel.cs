using System.ComponentModel.DataAnnotations;

namespace PlanningPoker.Shared
{
    public class RegisterModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Password must be at least 6 characters long.")]
        [DataType(DataType.Password)]
        [PasswordRequiresNonAlphanumeric]
        [PasswordRequiresUppercase]
        [PasswordRequiresLowercase]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }

        public bool AcceptPolicy { get; set; }
    }
}
