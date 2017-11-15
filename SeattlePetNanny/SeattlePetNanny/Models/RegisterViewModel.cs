﻿using System.ComponentModel.DataAnnotations;

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
        [Required]
        //[DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
    }
}
