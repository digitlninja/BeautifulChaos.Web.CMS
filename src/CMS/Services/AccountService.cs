using System;
using CMS.Interfaces;
using Data.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace CMS.Services
{
    public class AccountService : IAccountService
    {
        private UserManager<ApplicationUser> UserManager { get; }
        private SignInManager<ApplicationUser> SignInManager { get; }

        public AccountService(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IMailService mailService)
        {
            if (userManager == null)
                throw new ArgumentNullException(nameof(userManager));

            if (signInManager == null)
                throw new ArgumentNullException(nameof(signInManager));

            if (mailService == null)
                throw new ArgumentNullException(nameof(mailService));
            this.UserManager = userManager;
            this.SignInManager = signInManager;
        }

        public IdentityResult RegisterUser(string userId, string code)
        {
            if (string.IsNullOrEmpty(userId))
                return null;

            if (string.IsNullOrEmpty(code))
                return null;

            var user = this.UserManager.FindByIdAsync(userId).Result;
            var result = this.UserManager.ConfirmEmailAsync(user, code).Result;

            return result;
        }

    }
}