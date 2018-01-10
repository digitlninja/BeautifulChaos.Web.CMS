using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CMS.Controllers
{
    [Area("Admin")]
    [Route("admin")]
    [Authorize]
    public class DashboardController : Controller
    {
        [Route("dashboard")]
        public IActionResult Index()
        {
            return View();
        }
    }
}