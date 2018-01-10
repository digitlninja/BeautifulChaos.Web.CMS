using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using CMS.Interfaces;
using CMS.Services;
using Data.Entities.Identity;
using CMS.Models;

namespace CMS.Controllers
{
    [Area("Admin")]
    [Route("admin")]
    // ReSharper disable JoinNullCheckWithUsage
    public class AccountController : Controller
    {
        private UserManager<ApplicationUser> UserManager { get; }
        private SignInManager<ApplicationUser> SignInManager { get; }
        private IMailService MailService { get; }
        public IAccountService AccountService { get; }

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager,
            IMailService mailService, IAccountService accountService)
        {
            if (userManager == null)
                throw new ArgumentNullException(nameof(userManager));

            if (signInManager == null)
                throw new ArgumentNullException(nameof(signInManager));

            if (mailService == null)
                throw new ArgumentNullException(nameof(mailService));

            this.UserManager = userManager;
            this.SignInManager = signInManager;
            this.MailService = mailService;
            AccountService = accountService;
        }

        [HttpGet]
        [Route("login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpGet]
        [Route("register")]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [Route("register")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var userModel = new ApplicationUser {UserName = model.Username, Email = model.Email};

            var createUser = await this.UserManager.CreateAsync(userModel, model.Password);
            if (!createUser.Succeeded)
            {
                foreach (var registrationError in createUser.Errors)
                {
                    ModelState.AddModelError(string.Empty, registrationError.Description);
                }
                return View(model);
            }

            // Create confirm code and callback url, inject code into url and send mail with url
            var confirmMailBody = this.CreateConfirmMail(userModel);
            var sendMail =
                await this.MailService.SendEmailAsync(model.Email, "Confirm your account", confirmMailBody.Result);

            // If mail didn't send, return notification, else confirm message.
            if (!sendMail.Succeeded)
            {
                model.Succeeded = false;
                return View(model);
            }

            model.Succeeded = true;
            /*await this.SignInManager.SignInAsync(user, isPersistent: false);*/

            return View(model);
        }

        [HttpPost]
        [Route("login")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (model == null)
                return RedirectToAction("Register");

            var signIn = await this.SignInManager
                .PasswordSignInAsync(model.Username, model.Password, isPersistent: true, lockoutOnFailure: true);

            if (!signIn.Succeeded)
            {
                ModelState.AddModelError("LoginFailed",
                    "Sorry, we couldnt find a user with those credentials, please try again or Register an account.");
                return View("Login", model);
            }

            return RedirectToAction("Index", "Dashboard");
        }

        [HttpGet]
        public IActionResult ConfirmEmail(string userId, string code)
        {
            if (userId == null || code == null)
            {
                ViewData["error"] = "There was a problem with the confirm link, please contact support.";
                return View();
            }
            var register = this.AccountService.RegisterUser(userId, code);
            if (register.Succeeded)
            {
                ViewData["confirmStatus"] = "Email confirmed successfully!";
                return View();
            }

            ViewData["confirmStatus"] = "Your account wasn't confirmed, please try again.";
            return View();
        }

        public async Task<string> CreateConfirmMail(ApplicationUser user)
        {
            if (user == null)
                return null;

            var confirmCode = await this.UserManager.GenerateEmailConfirmationTokenAsync(user);
            var callbackUrl = Url.Action("ConfirmEmail", "Account", new
                {
                    userId = user.Id,
                    code = confirmCode
                },
                protocol: HttpContext.Request.Scheme);

            var confirmMsg = $"Please confirm your account by clicking this link: <a href='{callbackUrl}'>link</a>";
            return confirmMsg;
        }
    }
}