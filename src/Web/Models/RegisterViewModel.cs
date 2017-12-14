using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The password and confirmation doesn't match")]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }

        public bool Succeeded { get; set; }
    }
}
