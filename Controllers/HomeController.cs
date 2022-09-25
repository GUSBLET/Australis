using Microsoft.AspNetCore.Mvc;

namespace Australis.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Gallery()
        {
            return View();
        }
        public IActionResult Description()
        {
            return View();
        }

    }
}
