using System.ComponentModel.DataAnnotations;

namespace NogorDrishti.Models
{
    public class RegistrationModel
    {
        [Required(ErrorMessage = "Full name is required")]
        [StringLength(100, ErrorMessage = "Full name cannot exceed 100 characters")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Full name can only contain letters and spaces")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        [RegularExpression(@"^\d{11}$", ErrorMessage = "Phone number must be exactly 11 digits")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Date of birth is required")]
        [DataType(DataType.Date)]
        public DateOnly DateOfBirth { get; set; }

        [Required(ErrorMessage = "Division is required")]
        [StringLength(15, ErrorMessage = "Division cannot exceed 15 characters")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Division can only contain letters and spaces")]
        public string Division { get; set; }

        [Required(ErrorMessage = "District is required")]
        [StringLength(15, ErrorMessage = "District cannot exceed 15 characters")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "District can only contain letters and spaces")]
        public string District { get; set; }

        [Required(ErrorMessage = "Role is required")]
        public string Role { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Password must be between 6 and 100 characters")]
        [RegularExpression(@"^[A-Za-z\d@$!%*?&#.,-_+=]{6,}$", 
            ErrorMessage = "Password can only contain letters, numbers, and special characters (@$!%*?&#.,-_+=)")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm password is required")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string ConfirmPassword { get; set; }
    }
}
