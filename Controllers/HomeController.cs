using Microsoft.AspNetCore.Mvc;

namespace Australis.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
