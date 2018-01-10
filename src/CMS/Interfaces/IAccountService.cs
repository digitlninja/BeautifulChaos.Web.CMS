using Microsoft.AspNetCore.Identity;

namespace CMS.Interfaces
{
    public interface IAccountService
    {
        IdentityResult RegisterUser(string userId, string code);
    }
}