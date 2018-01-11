using Microsoft.AspNetCore.Mvc;

namespace CMS.Controllers
{
    [Area("Admin")]
    [Route("admin")]
    public class DashboardController : Controller
    {
        [Route("dashboard")]
        public IActionResult Index()
        {
            return View();
        }
    }
}