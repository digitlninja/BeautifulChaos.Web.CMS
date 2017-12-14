using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("about")]
        public IActionResult About()
        {
            return View();
        }

        [Route("services")]
        public IActionResult Services()
        {
            return View();
        }

        [Route("work")]
        public IActionResult Work()
        {
            return View();
        }

        [Route("testimonials")]
        public IActionResult Testimonials()
        {
            return View();
        }

        [Route("contact")]
        public IActionResult Contact()
        {
            return View();
        }
    }
}