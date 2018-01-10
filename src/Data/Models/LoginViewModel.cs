using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class LoginViewModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage = "For security reasons, Please make your password a minimum of 8 characters.")]
        public string Password { get; set; }
    }
}
