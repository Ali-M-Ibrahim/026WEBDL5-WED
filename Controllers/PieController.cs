using Microsoft.AspNetCore.Mvc;

namespace TPINCIWED.Controllers
{
    public class PieController : Controller
    {
        public IActionResult Index() //maps to pie/index or /pie
        {
            return Ok("i am pie controller and index action");
        }
    }
}
