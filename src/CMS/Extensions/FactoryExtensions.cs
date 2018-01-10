using CMS.Models;
using Data.Entities.Identity;

namespace CMS.Extensions
{
    public static class FactoryExtensions
    {
        public static UserModel ToModel(this ApplicationUser user)
        {
            if (user == null)
                return null;

            return new UserModel()
            {
                Email = user.Email,
                Username = user.UserName,
                Bio = user.Bio,
                Role = user.Role
            };
        }
    }
}
