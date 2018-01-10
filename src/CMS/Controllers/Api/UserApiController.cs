using System;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using CMS.Extensions;
using CMS.Interfaces;

namespace CMS.Controllers.Api
{
    [Produces("application/json")]
    public class UserApiController : Controller
    {
        private readonly IUserRepository UserRepository;

        public UserApiController(IUserRepository userRepository)
        {
            if(userRepository == null)
                throw new ArgumentException(nameof(userRepository));

            UserRepository = userRepository;
        }

        [HttpGet]
        [Route("api/user")]
        public IActionResult CurrentUser()
        {
            ClaimsPrincipal currentUser = this.User;
            var user = this.UserRepository.GetUser(currentUser).Result;
            var model = user.ToModel();
            return Ok(model);
        }
       
    }
}
