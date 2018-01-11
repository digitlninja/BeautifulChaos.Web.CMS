using System;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using CMS.Interfaces;
using Data.Entities.Identity;

namespace CMS.Repositories
{
    public class UserRepository : IUserRepository
    {
        private UserManager<ApplicationUser> UserManager { get; }

        public UserRepository(UserManager<ApplicationUser> userManager)
        {
            if (userManager == null)
                throw new ArgumentNullException(nameof(userManager));

            this.UserManager = userManager;
        }

        public async Task<ApplicationUser> GetUser(ClaimsPrincipal currentUser)
        {
            if (currentUser == null)
                return null;

            var user = await this.UserManager.GetUserAsync(currentUser);
            return user;
        }
    }
}
