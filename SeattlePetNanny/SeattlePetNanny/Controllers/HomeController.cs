using Microsoft.AspNetCore.Mvc;

namespace SeattlePetNanny.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Rates()
        {
            return View();
        }
    }
}
