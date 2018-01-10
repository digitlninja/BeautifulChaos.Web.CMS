using Microsoft.AspNetCore.Mvc;

namespace CMS.Controllers
{
    [Area("Admin")]
    [Route("admin")]
    public class UserController : Controller
    {
        [Route("users")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
