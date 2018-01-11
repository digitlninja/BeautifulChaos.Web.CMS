using Data.Entities.Identity;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CMS.Interfaces
{
    public interface IUserRepository
    {
        Task<ApplicationUser> GetUser(ClaimsPrincipal currentUser);
    }
}