using System;
using Data.Contexts;
using Microsoft.AspNetCore.Mvc;

namespace CMS.Controllers.Api
{
    public class AdminApiController : Controller
    {
        public BeautifulChaosContext Context { get; }

        public AdminApiController(BeautifulChaosContext context)
        {
            if(context == null)
                throw new ArgumentNullException(nameof(context));

            this.Context = context;
        }

//        [HttpGet, Route("about")]
//        public IActionResult About()
//        {
//           
//        }


    }
}