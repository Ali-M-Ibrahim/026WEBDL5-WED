using Microsoft.AspNetCore.Mvc;

namespace TPINCIWED.Controllers
{
    public class WebsiteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
            //return View("Views/Data/Data.cshtml");
        }
    }
}
