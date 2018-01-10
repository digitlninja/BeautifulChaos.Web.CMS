using Microsoft.AspNetCore.Identity;

namespace Data.Entities.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public string Bio { get; set; }
        public string Role { get; set; }
    }
}
