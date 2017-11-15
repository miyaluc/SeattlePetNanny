using System.ComponentModel.DataAnnotations;

namespace SeattlePetNanny.Models
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(20, ErrorMessage = "Please enter a valid password", MinimumLength = 8)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Your passwords do not match")]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }

        //[DataType(DataType.Date)]
        //public DateTime Birthday { get; set; }

        //[Required]
        //public string FirstName { get; set; }
        //[Required]
        //public string LastName { get; set; }
        //[DataType(DataType.PhoneNumber)]
        [Required]
        [RegularExpression("^[01]?[- .]?\\(?[2-9]\\d{2}\\)?[- .]?\\d{3}[- .]?\\d{4}$",
        ErrorMessage = "Phone is required and must be properly formatted.")]
        [Display(Order = 9, Name = "Phone")]
        public string PhoneNumber { get; set; }
    }
}
