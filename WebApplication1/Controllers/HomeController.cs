using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()

        {

            return View();
        }

        public IActionResult Product()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Store()
        {
            return View();
        }
    }
}
