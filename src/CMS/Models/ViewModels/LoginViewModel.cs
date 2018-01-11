using System.ComponentModel.DataAnnotations;
using FluentValidation.Attributes;

namespace CMS.Models.ViewModels
{
    [Validator(typeof(LoginViewModel))]
    public class LoginViewModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
